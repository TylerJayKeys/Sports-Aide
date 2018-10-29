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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void StatsMenu_Activated(object sender, EventArgs e)
        {
            // Shutdown item drawing while data is collected
            listBox1.BeginUpdate();

            listBox1.Items.Clear();

            foreach (string name in Player.GetAll())
            {
                listBox1.Items.Add(name);
            }

            listBox1.EndUpdate();
        }

        // REFRESH BUTTON
        private void refreshBtn_Click(object sender, EventArgs e)
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

        // BACK BUTTON
        private void backBtn_Click(object sender, EventArgs e)
        {
            Core.OpenForm(Core.MainMenu);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string name = listBox1.SelectedItem.ToString();
                plyImgBox.Image = Core.SQLGetImage(name);

                List<string> player = Player.Get(name);
                List<List<string>> stats = Player.GetStats(player[0]);

                plyName.Text = name;
                posText.Text = player[6];
                activeText.Text = player[4] == "1" ? "Active" : "Inactive";

                List<string> lastThree = new List<string>();

                int goals = new int();
                int playtime = new int();
                int saves = new int();
                int distance = new int();

                // Get the amount of goals for the last 3 games
                foreach (List<string> stat in stats)
                {
                    int latest = Core.GetLatestGame();

                    if (int.Parse(stat[0]) == latest || int.Parse(stat[0]) == latest - 1 || int.Parse(stat[0]) == latest - 2)
                    {
                        goals += int.Parse(stat[3]);
                        playtime += int.Parse(stat[4]);
                        saves += int.Parse(stat[5]);
                        distance += int.Parse(stat[2]);
                    }
                }

                // Displaying the "fun fact"
                string firstName = name.Split(' ')[0];

                // Displays a different fact depending on the player's role
                switch (player[6])
                {
                    case "Midfielder":
                        factText.Text = firstName + " travelled " + distance + "m in the last 3 games.";
                        txtGoal.Text = "Goals Scored:";
                        statGoals.Text = goals.ToString();
                        break;
                    case "Goalkeeper":
                        factText.Text = firstName + " saved " + saves + " goals in the last 3 games.";
                        txtGoal.Text = "Goals Saved:";
                        statGoals.Text = saves.ToString();
                        break;
                    case "Defender":
                        factText.Text = firstName + " played " + playtime + " minutes in the last 3 games.";
                        txtGoal.Text = "Goals Scored:";
                        statGoals.Text = goals.ToString();
                        break;
                    case "Forward":
                        factText.Text = firstName + " scored " + goals + " goals in the last 3 games.";
                        txtGoal.Text = "Goals Scored:";
                        statGoals.Text = goals.ToString();
                        break;
                }

                statAssists.Text = player[16];
                statPlaytime.Text = player[10] + " minutes";
                statIntercept.Text = player[12];
                statTackles.Text = player[13];
                statFouls.Text = player[14];
                statOffside.Text = player[15];
                statDistance.Text = player[9] + "m";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
