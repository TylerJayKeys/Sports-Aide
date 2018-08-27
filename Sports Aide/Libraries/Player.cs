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
        static List<List<string>> _plydata = Core.GetTeamData();

        public static bool Add(string name)
        {
            string[] str = name.Split(' ');

            if (str.GetLength(0) > 2)
            {
                MessageBox.Show("You can only enter two names!", "Name Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (name == "" || name == "Player Name")
            {
                MessageBox.Show("You must enter a name!", "Name Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                Core.SQLQuery(string.Format("INSERT INTO players (firstname, lastname) VALUES (\"{0}\", \"{1}\");", name.Split(' ')[0], name.Split(' ')[1]));
                return true;
            }
        }

        public static void Remove(string name)
        {
            throw new NotImplementedException();
        }

        public static List<string> GetAll()
        {
            List<string> list = new List<string> { };

            foreach (List<string> player in Core.GetTeamData())
            {
                // Index starts at 1 since 0 is the player ID
                list.Add(player[1] + " " + player[2]);
            }

            return list;
        }

        public static void LoadNames(string db)
        {
            // Save chosen DB to compiler to be referenced later

            throw new NotImplementedException();
        }

        public static void Sync()
        {
            // Use DB used and saved in Player.Load

            throw new NotImplementedException();
        }
    }
}
