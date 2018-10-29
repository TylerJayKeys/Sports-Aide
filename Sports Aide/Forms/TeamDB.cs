using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SportsAide
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Shutdown item drawing while data is collected
            listBox1.BeginUpdate();

            foreach (string name in Player.GetAll())
            {
                listBox1.Items.Add(name);
            }

            listBox1.EndUpdate();
        }

        // BACK BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            Core.OpenForm(Core.MainMenu);
        }

        // REMOVE BUTTON
        private void rmbtn_Click(object sender, EventArgs e)
        {
            object name = listBox1.SelectedItem;

            if (name != null)
            {
                Player.Remove(name.ToString());
                listBox1.Items.Remove(name);
            }
        }

        // ADD PLAYER BUTTON
        private void addBTN_Click(object sender, EventArgs e)
        {
            if (Player.Add(plyname.Text))
            {
                listBox1.Items.Add(plyname.Text);
                listBox1.SelectedItem = plyname.Text;
            }
            
        }

        // REFRESH BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            // Shutdown item drawing while data is collected
            listBox1.BeginUpdate();
            
            listBox1.Items.Clear();

            // Get all NAMES from SQLite
            foreach (string name in Player.GetAll())
            {
                listBox1.Items.Add(name);
            }

            listBox1.EndUpdate();
        }

        // Load all info when a player is selected.
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Index will be invalid when removing items.
            if (listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();
                string[] nameArray = name.Split(' ');

                List<string> data = new List<string>();

                // Gets the list with player data
                data = Player.Get(name);

                plyImgBox.Image = Core.SQLGetImage(name);

                txtFirstName.Text = nameArray[0];
                txtLastName.Text = nameArray[1];

                // sets textboxes/checkboxes based on SQL data
                posBox.Text = data[6];
                activeCheck.CheckState = int.Parse(data[4]) == 1 ? CheckState.Checked : CheckState.Unchecked;
                plyNotes.Text = data[7];
            }
            else // Clear info if nothing is selected
            {
                plyImgBox.Image = null;

                txtFirstName.Text = "";
                txtLastName.Text = "";

                posBox.SelectedItem = "";
                activeCheck.CheckState = CheckState.Unchecked;
                plyNotes.Text = "";
            }
        }

        // UPLOAD IMAGE BUTTON
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            dialog.Title = "Select a Player Image";

            // Ensure an item is selected
            if (listBox1.SelectedItem != null)
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap img = new Bitmap(dialog.OpenFile());

                    plyImgBox.Image = img;
                    Core.SQLSetImage(listBox1.SelectedItem.ToString(), plyImgBox.Image);
                }
            }
            else
            {
                MessageBox.Show("You must have a player selected!", "No Selection!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // REMOVE IMAGE BUTTON
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove the image?", "Remove Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                // Sets the SQL image to 'null' in order to remove it from the DB
                Core.SQLSetImage(listBox1.SelectedItem.ToString(), null);
                plyImgBox.Image = null;
            }
        }

        // SAVE BUTTON
        // Commits the textbox/checkbox data to the database with a query
        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                string[] name = listBox1.SelectedItem.ToString().Split(' ');

                Core.SQLQuery(string.Format("UPDATE players SET firstname = '{0}', lastname = '{1}', team_id = {2}, active = {3}, position = '{4}', notes = '{5}' WHERE (firstname, lastname) = ('{6}', '{7}')",
                  txtFirstName.Text, txtLastName.Text, "1", activeCheck.CheckState == CheckState.Checked ? "1" : "0", posBox.Text, plyNotes.Text, name[0], name[1]));

                // Temporarily shuts down item drawing to take out the old name and slot in the new one
                listBox1.BeginUpdate();

                string[] newname = { txtFirstName.Text, txtLastName.Text };

                listBox1.Items.Insert(listBox1.SelectedIndex, string.Join(" ", newname));
                listBox1.Items.Remove(listBox1.SelectedItem);

                listBox1.EndUpdate();

                MessageBox.Show("Player saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You must have a player selected!", "No Selection!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CANCEL BUTTON
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel?", "Cancel Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if yes was pressed and if something is selected.
            if (dialogResult == DialogResult.Yes && listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();

                List<string> data = Player.Get(name);

                txtFirstName.Text = name.Split(' ')[0];
                txtLastName.Text = name.Split(' ')[1];

                posBox.Text = data[6];
                activeCheck.CheckState = data[4] == "1" ? CheckState.Checked : CheckState.Unchecked;
                plyNotes.Text = data[7];
            }
            else if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("You must have a player selected!", "No Selection!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Prevents user from putting spaces in the name boxes so that
        // there can only be two names
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}