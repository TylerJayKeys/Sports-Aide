using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            listBox1.Items.Remove(listBox1.SelectedItem);
            Player.Remove(listBox1.SelectedItem.ToString());
        }

        // ADD PLAYER BUTTON
        private void addBTN_Click(object sender, EventArgs e)
        {
            if (Player.Add(plyname.Text))
            {
                listBox1.Items.Add(plyname.Text);
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
            // Index will definitely be invalid when removing items.
            if (listBox1.SelectedIndex != -1)
            {
                plyLabel.Text = listBox1.SelectedItem.ToString();
                plyImgBox.Image = Core.SQLGetImage(listBox1.SelectedItem.ToString());
            }
        }

        // UPLOAD IMAGE BUTTON
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            dialog.Title = "Select a Player Image";

            // CHANGE THIS TO CALL IMAGE PROCESSING
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = new Bitmap(dialog.OpenFile());

                Core.SQLSetImage(listBox1.SelectedItem.ToString(), img);
                plyImgBox.Image = img;
            }
        }

        // REMOVE IMAGE BUTTON
        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove the image?", "Remove Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Core.SQLSetImage(listBox1.SelectedItem.ToString(), null);
                plyImgBox.Image = null;
            }
        }
    }
}