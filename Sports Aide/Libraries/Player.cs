using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;


namespace SportsAide
{
    public static class Player
    {
        // Adds only a player name to the database, automatically creating an ID in the process.
        public static bool Add(string name)
        {
            string[] str = name.Split(' ');

            // ERROR TRAPPING:
            // Only allow two names for the sake of ease when implementing into SQL.
            if (str.GetLength(0) > 2)
            {
                MessageBox.Show("You can only enter two names!", "Name Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Make sure the name isn't blank or the default name.
            else if (name == "" || name == "Player Name")
            {
                MessageBox.Show("You must enter a name!", "Name Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (str.GetLength(0) < 2)
            {
                MessageBox.Show("You have to enter two names!", "Name Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                Core.SQLQuery(string.Format("INSERT INTO players (firstname, lastname) VALUES (\"{0}\", \"{1}\");", name.Split(' ')[0], name.Split(' ')[1]));
                return true;
            }
        }

        // Deletes the player's record.
        public static void Remove(string name)
        {
            string[] ply = name.Split(' ');
            Core.SQLQuery("DELETE FROM players WHERE (firstname, lastname) = ('" + ply[0] + "', '" + ply[1] + "');");
        }

        // Returns a list with every player's name.
        public static List<string> GetAll()
        {
            List<string> list = new List<string> { };

            foreach (List<string> player in Core.GetTeamData())
            {
                // Index starts at 1 since 0 is the player ID
                // See the core library for the array indexes.
                list.Add(player[1] + " " + player[2]);
            }

            return list;
        }

        // Queries the teamdata list for the specified player's list.
        public static List<string> Get(string name)
        {
            string[] nameArray = name.Split(' ');

            foreach (List<string> player in Core.GetTeamData())
            {
                if (player[1] == nameArray[0] && player[2] == nameArray[1])
                {
                    return player;
                }
            }

            return null;
        }

        // Queries the STATS list for the specified PLAYER ID's list.
        public static List<List<string>> GetStats(string id)
        {
            List<List<string>> data = new List<List<string>>();

            foreach (List<string> table in Core.GetTeamStats())
            {
                if (table[1] == id)
                {
                    data.Add(table);
                }
            }

            return data ?? null;
        }
    }
}
