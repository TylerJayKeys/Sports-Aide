using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sports_Aide.Forms;

namespace SportsAide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This is where the forms we instantiated in the Core library
        // are actually loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            Core.MainMenu = this;
            Core.PlayerMenu = new Form2();
            Core.TrackerMenu = new Form3();

            MessageBox.Show("Welcome! Hover over items in this window to find out what they do.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // TEAM DATABASE MENU
        private void button1_Click(object sender, EventArgs e) // Team Menu
        {
            Core.OpenForm(Core.PlayerMenu);
        }

        // TEAM STATISTICS MENU
        private void button2_Click(object sender, EventArgs e) // Tracker
        {
            Core.OpenForm(Core.TrackerMenu);
        }

        // EXIT BUTTON
        private void button4_Click(object sender, EventArgs e) // Exit Button
        {
            Application.Exit();
        }

        // Sets the player of the week/mvp by switching on an integer in one of the database values
        // for a particular value.
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PlayerSelect plySelect = new PlayerSelect();

            if (plySelect.ShowDialog(this) == DialogResult.OK)
            {
                string[] name = plySelect.Selection.Split(' ');

                if (potwName.Text != "Select a Player")
                {
                    Core.SQLQuery("UPDATE players SET potw = 0 WHERE (firstname, lastname) = ('" + potwName.Text.Split(' ')[0] + "', '" + potwName.Text.Split(' ')[1] + "');");
                }

                Core.SQLQuery("UPDATE players SET potw = 1 WHERE (firstname, lastname) = ('" + name[0] + "', '" + name[1] + "');");

                potwImgBox.Image = Core.SQLGetImage(plySelect.Selection);
                potwName.Text = plySelect.Selection;
                potwFact();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // This is called more than once so I quickly shoved it into a function to avoid a big mess.
            potwFact();
        }

        // Opens the new game dialog.
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Checks if there are players to create stats for.
            if (Player.GetAll().Count != 0)
            {
                NewGame game = new NewGame();

                game.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must have players in your team!", "No Players!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Finds the MVP and shows their details on the main page.
        private void potwFact()
        {
            string potw = null;

            // Loops through every player until one of them has the potw tag enabled.
            foreach (List<string> player in Core.GetTeamData())
            {
                if (player[8] == "1")
                {
                    // Index starts at 1 since player[0] is the ID
                    potw = player[1] + ' ' + player[2];
                    break;
                }
            }

            // Makes sure there is actually an MVP to show.
            if (potw != null)
            {
                // Show's the name as the title.
                potwName.Text = potw;

                // Displays the player's image.
                potwImgBox.Image = Core.SQLGetImage(potw);

                List<string> player = Player.Get(potw);
                List<List<string>> stats = Player.GetStats(player[0]);

                int goals = new int();
                int playtime = new int();
                int distance = new int();

                // Get the amount of goals, minutes played, and distance travelled for the last 3 games
                foreach (List<string> stat in stats)
                {
                    int latest = Core.GetLatestGame();

                    // Gets the latest game and checks if the game ID 
                    if (int.Parse(stat[0]) == latest || int.Parse(stat[0]) == latest - 1 || int.Parse(stat[0]) == latest - 2)
                    {
                        goals += int.Parse(stat[3]);
                        playtime += int.Parse(stat[4]);
                        distance += int.Parse(stat[2]);
                    }
                }

                string firstName = potw.Split(' ')[0];

                txtPotw.Text = string.Format("{0} played for {1} minutes, travelled {2} metres and scored {3} goals in the last 3 games", firstName, playtime.ToString(), distance.ToString(), goals.ToString());
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MediaLink link = new MediaLink();

            if (link.ShowDialog() == DialogResult.OK)
            {
                var embed = "<html><head>" +
                            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                            "</head><body>" +
                            "<iframe width=\"300\" src=\"{0}\"" +
                            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                            "</body></html>";

                var url = link.Selection;

                webBrowser1.DocumentText = string.Format(embed, url);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            dialog.Title = "Select a Team Image";


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap img = new Bitmap(dialog.OpenFile());

                pictureBox1.Image = img;
            }

        }
    }
}
