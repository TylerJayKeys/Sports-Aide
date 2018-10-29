using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;
using System.IO;

namespace SportsAide
{
    public static class Core
    {
        // This instantiates all forms in a global scope to avoid having to load
        // lots of duplicates.
        public static Form MainMenu;
        public static Form PlayerMenu;
        public static Form TrackerMenu;

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

            // SQL connection formalities...
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
                            // player_id INT (0), firstname (1), lastname (2), team_id INT (3), active INT (4), goals INT (5), position (6), notes (7), player of the week (8)
                            // distance (9), playtime (10), saved (11), interceptions (12), tackles (13), fouls (14), offsides (15), assists (16)
                            List<string> add = new List<string> { rd.GetInt32(0).ToString(), rd.GetString(1),
                              rd.GetString(2), rd.GetInt32(4).ToString(), rd.GetInt32(5).ToString(), rd.GetInt32(6).ToString(),
                                rd.GetString(7), rd.GetString(8), rd.GetInt32(9).ToString(), rd.GetInt32(10).ToString(), rd.GetInt32(11).ToString(),
                                rd.GetInt32(12).ToString(), rd.GetInt32(13).ToString(), rd.GetInt32(14).ToString(), rd.GetInt32(15).ToString(),
                                rd.GetInt32(16).ToString(), rd.GetInt32(17).ToString()};

                            data.Add(add);
                        }
                    }
                }

                conn.Close();
            }

            return data;
        }

        // Has the same function as GetTeamData but queries the single-game stats menu instead.
        public static List<List<string>> GetTeamStats()
        {
            List<List<string>> data = new List<List<string>>();

            using (SQLiteConnection conn = new SQLiteConnection("data source=sportsaide.db"))
            {
                conn.Open();

                string query = "SELECT * FROM stats";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rd = cmd.ExecuteReader())
                    {
                        // Loop over each row in the table, returning true if there is another row to iterate over.
                        while (rd.Read())
                        {
                            // Add list with this order:
                            // game_id (0), player_id (1), distance (2), goals (3), playtime (4), saved (5), interceptions (6), tackles (7), fouls (8)
                            // offsides (9), assists (10)
                            List<string> add = new List<string> { rd.GetInt32(0).ToString(), rd.GetInt32(1).ToString(), rd.GetInt32(2).ToString(),
                                rd.GetInt32(3).ToString(), rd.GetInt32(4).ToString(), rd.GetInt32(5).ToString(), rd.GetInt32(6).ToString(),
                                rd.GetInt32(7).ToString(), rd.GetInt32(8).ToString(), rd.GetInt32(9).ToString(), rd.GetInt32(10).ToString()};

                            data.Add(add);
                        }
                    }
                }

                conn.Close();
            }

            return data;
        }

        // Same function as GetTeamData but with the games table.
        public static List<List<string>> GetGames()
        {
            List<List<string>> data = new List<List<string>>();

            using (SQLiteConnection conn = new SQLiteConnection("data source=sportsaide.db"))
            {
                conn.Open();

                string query = "SELECT * FROM games";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    using (SQLiteDataReader rd = cmd.ExecuteReader())
                    {
                        // Loop over each row in the table, returning true if there is another row to iterate over.
                        while (rd.Read())
                        {
                            // Add list with this order:
                            // game_id (0), date (1)
                            List<string> add = new List<string> { rd.GetInt32(0).ToString(), rd.GetString(1)};

                            data.Add(add);
                        }
                    }
                }

                conn.Close();
            }

            return data;
        }

        // Gets the game ID of the latest game by iterating over each game in the table.
        public static int GetLatestGame()
        {
            int count = 0;

            foreach (List<string> game in GetGames())
            {
                count += 1;
            }

            return count;
        }

        // Purely run a query on the DB, does not return any usable values.
        // Good for doing table inserts or other external DB manipulation that doesn't involve retrieving data.
        public static void SQLQuery(string query, bool debug = false)
        {
            if (debug)
            {
                Console.WriteLine(query);
            }

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

        // Converts an image into a byte stream and stores it in the SQL database.
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
                // Saves the image to the datastream in order to convert it to a byte array.
                img.Save(ms, img.RawFormat);
                data = ms.ToArray();

                // Usual SQL connection formalities
                using (SQLiteConnection conn = new SQLiteConnection("data source=sportsaide.db"))
                {
                    conn.Open();
                    
                    SQLiteCommand cmd = new SQLiteCommand(conn);

                    cmd.CommandText = "UPDATE players SET picture = @data WHERE (firstname, lastname) = ('" + ply[0] + "', '" + ply[1] + "');";
                    cmd.Prepare();

                    // SQL only likes BLOBs coming in as a prepared data byte as opposed to a pure string query apparently.
                    cmd.Parameters.Add("@data", System.Data.DbType.Binary, data.Length);
                    cmd.Parameters["@data"].Value = data;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                }
            }
        }


        // Retrieves a player's image from the SQL database by rebuilding it from its byte stream.
        public static Image SQLGetImage(string player)
        {
            string[] ply = player.Split(' ');
            byte[] data;

            using (SQLiteConnection conn = new SQLiteConnection("data source=sportsaide.db"))
            {
                conn.Open();

                SQLiteCommand cmd = new SQLiteCommand(conn);
                cmd.CommandText = "SELECT picture FROM players WHERE (firstname, lastname) = ('" + ply[0] + "', '" + ply[1] + "');";

                // SQL returns type 'DBNull' instead of 'null' if the query result is empty.
                // ExecuteScalar() will break the program if DBNull is returned so a ternary operator is used to
                // do a check whilst remaining in the same scope as the variables I need to mess with.
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
