using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportsAide;

namespace Sports_Aide.Forms
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        // Get all players for the listbox
        // Also creates a new game to be referenced in the stats DB
        private void NewGame_Activated(object sender, EventArgs e)
        {
            Core.SQLQuery("INSERT INTO games (date) VALUES ('" + gameDate.Value.ToShortDateString() + "');");

            // Shutdown item drawing while data is collected
            listBox1.BeginUpdate();

            listBox1.Items.Clear();

            foreach (string name in Player.GetAll())
            {
                listBox1.Items.Add(name);
            }

            listBox1.EndUpdate();

            foreach (string player in listBox1.Items)
            {
                Core.SQLQuery(String.Format("INSERT INTO stats (game_id, player_id) VALUES ((SELECT MAX(game_id) FROM games), (SELECT player_id FROM players WHERE (firstname, lastname) = ('{0}', '{1}')));",
                    player.Split(' ')[0], player.Split(' ')[1]));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Core.SQLQuery("UPDATE games SET date = '" + gameDate.Value.ToShortDateString() + "' WHERE game_id = (SELECT MAX(game_id) FROM games);");
            Console.WriteLine(gameDate.Value.ToShortDateString());
        }

        // Used by all stat buttons.
        // Gets the button's tag (which is set to its corresponding row in the database) and increments its value
        private void statBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string stat = (string)button.Tag;

            if (listBox1.SelectedItem != null)
            {
                string[] name = listBox1.SelectedItem.ToString().Split(' ');

                Core.SQLQuery(string.Format("UPDATE stats SET {0} = {0} + 1 WHERE player_id = ((SELECT player_id FROM players WHERE (firstname, lastname) = ('{1}', '{2}'))) AND game_id = ((SELECT MAX(game_id) FROM games));", stat, name[0], name[1]), true);
            }
            else
            {
                MessageBox.Show("You must have a player selected!", "No Selection!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // DISTANCE BUTTON
        // adds the number box data to the stats DB
        private void btnDist_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string stat = (string)button.Tag;

            if (listBox1.SelectedItem != null)
            {
                string[] name = listBox1.SelectedItem.ToString().Split(' ');

                Core.SQLQuery(string.Format("UPDATE stats SET {0} = {0} + {1} WHERE player_id = ((SELECT player_id FROM players WHERE (firstname, lastname) = ('{2}', '{3}'))) AND game_id = ((SELECT MAX(game_id) FROM games));", "distance", numDist.Value.ToString(), name[0], name[1]), true);
            }
            else
            {
                MessageBox.Show("You must have a player selected!", "No Selection!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // PLAYTIME BUTTON
        // Adds the number box data to the stats DB
        private void btnPlaytime_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string stat = (string)button.Tag;

            if (listBox1.SelectedItem != null)
            {
                string[] name = listBox1.SelectedItem.ToString().Split(' ');

                Core.SQLQuery(string.Format("UPDATE stats SET {0} = {0} + {1} WHERE player_id = ((SELECT player_id FROM players WHERE (firstname, lastname) = ('{2}', '{3}'))) AND game_id = ((SELECT MAX(game_id) FROM games));", "playtime", numPlayTime.Value.ToString(), name[0], name[1]), true);
            }
            else
            {
                MessageBox.Show("You must have a player selected!", "No Selection!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Loops over every player and increments all global stats based on those of the current game
        private void StatsMenu_Deactivate(object sender, EventArgs e)
        {
            foreach (string player in listBox1.Items)
            {
                // distance
                Core.SQLQuery(string.Format("UPDATE players SET distance = distance + (SELECT distance FROM stats WHERE stats.player_id = {0} AND stats.game_id = (SELECT MAX(game_id) FROM games)) WHERE (firstname, lastname) = ('{1}', '{2}');", Player.Get(player)[0], player.Split(' ')[0], player.Split(' ')[1]));
                
                // goals
                Core.SQLQuery(string.Format("UPDATE players SET goals = goals + (SELECT goals FROM stats WHERE stats.player_id = {0} AND stats.game_id = (SELECT MAX(game_id) FROM games)) WHERE (firstname, lastname) = ('{1}', '{2}');", Player.Get(player)[0], player.Split(' ')[0], player.Split(' ')[1]));
                
                // playtime
                Core.SQLQuery(string.Format("UPDATE players SET playtime = playtime + (SELECT playtime FROM stats WHERE stats.player_id = {0} AND stats.game_id = (SELECT MAX(game_id) FROM games)) WHERE (firstname, lastname) = ('{1}', '{2}');", Player.Get(player)[0], player.Split(' ')[0], player.Split(' ')[1]));
                
                // saved
                Core.SQLQuery(string.Format("UPDATE players SET saved = saved + (SELECT saved FROM stats WHERE stats.player_id = {0} AND stats.game_id = (SELECT MAX(game_id) FROM games)) WHERE (firstname, lastname) = ('{1}', '{2}');", Player.Get(player)[0], player.Split(' ')[0], player.Split(' ')[1]));
                
                // interceptions
                Core.SQLQuery(string.Format("UPDATE players SET interceptions = interceptions + (SELECT interceptions FROM stats WHERE stats.player_id = {0} AND stats.game_id = (SELECT MAX(game_id) FROM games)) WHERE (firstname, lastname) = ('{1}', '{2}');", Player.Get(player)[0], player.Split(' ')[0], player.Split(' ')[1]));
                
                // tackles
                Core.SQLQuery(string.Format("UPDATE players SET tackles = tackles + (SELECT tackles FROM stats WHERE stats.player_id = {0} AND stats.game_id = (SELECT MAX(game_id) FROM games)) WHERE (firstname, lastname) = ('{1}', '{2}');", Player.Get(player)[0], player.Split(' ')[0], player.Split(' ')[1]));
                
                // fouls
                Core.SQLQuery(string.Format("UPDATE players SET fouls = fouls + (SELECT fouls FROM stats WHERE stats.player_id = {0} AND stats.game_id = (SELECT MAX(game_id) FROM games)) WHERE (firstname, lastname) = ('{1}', '{2}');", Player.Get(player)[0], player.Split(' ')[0], player.Split(' ')[1]));
                
                // offsides
                Core.SQLQuery(string.Format("UPDATE players SET offsides = offsides + (SELECT offsides FROM stats WHERE stats.player_id = {0} AND stats.game_id = (SELECT MAX(game_id) FROM games)) WHERE (firstname, lastname) = ('{1}', '{2}');", Player.Get(player)[0], player.Split(' ')[0], player.Split(' ')[1]));
                
                // assists
                Core.SQLQuery(string.Format("UPDATE players SET assists = assists + (SELECT assists FROM stats WHERE stats.player_id = {0} AND stats.game_id = (SELECT MAX(game_id) FROM games)) WHERE (firstname, lastname) = ('{1}', '{2}');", Player.Get(player)[0], player.Split(' ')[0], player.Split(' ')[1]));
            }
        }

        // Refresh list button
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
    }
}
