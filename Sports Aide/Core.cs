using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsAide
{
    public static class Core
    {
        public static Form MainMenu;
        public static Form PlayerMenu;
        public static Form TrackerMenu;
        public static Form MediaMenu;

        public static void OpenForm(Form f, bool closeLast = true)
        {
            if (closeLast) {
                Form.ActiveForm.Hide();
            }
            f.Show();
        }

        // Open database, query all table data and output as List in List
        public static List<List<string>> GetTeamData()
        {
            List<List<string>> data = new List<List<string>>();

            using (SQLiteConnection conn = new SQLiteConnection("data source=sportsaide.db"))
            {
                conn.Open();

                string query = "SELECT * FROM players";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            // Add list with this order:
                            // player_id INT, firstname, lastname, team_id INT, active INT, goals INT
                            List<string> add = new List<string> { rd.GetInt32(0).ToString(), rd.GetString(1),
                             rd.GetString(2), rd.GetInt32(4).ToString(), rd.GetInt32(5).ToString(), rd.GetInt32(6).ToString() };

                            data.Add(add);
                        }
                    }
                }

                conn.Close();
            }

            return data;
        }

        // Purely run a query on the DB, does not return any usable values
        // Good for doing table inserts or other external DB manipulation
        public static void SQLQuery(string query)
        {
            using (SQLiteConnection conn = new SQLiteConnection("data source=sportsaide.db"))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
    }
}
