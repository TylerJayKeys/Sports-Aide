using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;
using System.IO;

namespace SportsAide
{
    public static class Core
    {
        public static Form MainMenu;
        public static Form PlayerMenu;
        public static Form TrackerMenu;
        public static Form MediaMenu;

        // Global function for opening and closing forms.
        public static void OpenForm(Form f, bool closeLast = true)
        {
            if (closeLast)
            {
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
                        // Loop over each row in the table, returning true if there is another row to iterate over.
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

        /// <summary>
        /// Purely run a query on the DB, does not return any usable values.
        /// Good for doing table inserts or other external DB manipulation that doesn't involve retrieving data.
        /// </summary>
        /// <param name="query">SQL query in string format.</param>
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

        /// <summary>
        /// Converts an image into a byte stream and stores it in the SQL database.
        /// </summary>
        /// <param name="player">Name of the player who's image we're storing in the database.</param>
        /// <param name="img">Image to be converted and stored.</param>
        public static void SQLSetImage(string player, Image img)
        {
            string[] ply = player.Split(' ');
            byte[] data;

            // Removes the image from the database then breaks the function if the img argument is null.
            if (img == null)
            {
                SQLQuery("UPDATE players SET picture = NULL WHERE (firstname, lastname) = ('" + ply[0] + "', '" + ply[1] + "');");
                return;
            }

            using (var ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                data = ms.ToArray();

                using (SQLiteConnection conn = new SQLiteConnection("data source=sportsaide.db"))
                {
                    conn.Open();
                    
                    SQLiteCommand cmd = new SQLiteCommand(conn);

                    cmd.CommandText = "UPDATE players SET picture = @data WHERE (firstname, lastname) = ('" + ply[0] + "', '" + ply[1] + "');";
                    cmd.Prepare();

                    cmd.Parameters.Add("@data", System.Data.DbType.Binary, data.Length);
                    cmd.Parameters["@data"].Value = data;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }

        /// <summary>
        /// Retrieves a player's image from the SQL database.
        /// </summary>
        /// <param name="player">Name of the player who's image we're retrieving.</param>
        /// <returns>Player's image.</returns>
        public static Image SQLGetImage(string player)
        {
            string[] ply = player.Split(' ');
            byte[] data;

            using (SQLiteConnection conn = new SQLiteConnection("data source=sportsaide.db"))
            {
                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = "SELECT picture FROM players WHERE (firstname, lastname) = ('" + ply[0] + "', '" + ply[1] + "');";

                // SQL returns type DBNull instead of null if the query result is empty.
                // ExecuteScalar() will break the program if DBNull is returned so I use a ternary operator to
                // do a check whilst remaining in the same scope.
                data = cmd.ExecuteScalar().GetType() != typeof(DBNull) ? (byte[])cmd.ExecuteScalar() : null;

                conn.Close();

                if (data != null)
                {
                    using (var ms = new MemoryStream(data))
                    {
                        return Image.FromStream(ms);
                    }
                } else
                {
                    return null;
                }
            }
        }
    }
}
