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
            if (closeLast == true) {
                Form.ActiveForm.Hide();
            }
            f.Show();
        }

        public static List<string> SyncSQLTeamData() // TODO
        {

            List<string> data = new List<string>();

            using (SQLiteConnection conn = new SQLiteConnection("data source=sportsaide.db3"))
            {
                conn.Open();

                string query = "SELECT * FROM players"

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            add = new List<string> {}; // ADD EACH ROW

                            data.Add(add);
                        }
                    }
                }
            }
        }
    }
}
