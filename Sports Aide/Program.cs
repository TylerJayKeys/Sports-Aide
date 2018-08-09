using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SportsAide
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initial bootup of the database.
            // Does first time setup where required.
            string createQuery = @"CREATE TABLE IF NOT EXISTS [players] (
                                    [player_id] INTEGER  NOT NULL
                                    , [firstname] text NOT NULL
                                    , [lastname] text NOT NULL
                                    , [picture] image NULL
                                    , [team_id] bigint DEFAULT 1 NOT NULL
                                    , [active] bigint DEFAULT 1  NOT NULL
                                    , [goals] bigint DEFAULT 0  NOT NULL
                                    , CONSTRAINT [sqlite_master_PK_players] PRIMARY KEY ([player_id])
                                    );";

            using (SQLiteConnection conn = new SQLiteConnection("data source=sportsaide.db")) // This is where db file is created if it doesn't already exist
            {
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    cmd.CommandText = createQuery; // Runs the CREATE TABLE query above.
                    cmd.ExecuteNonQuery(); // Execute SQL equivalent of "endline".
                };

                conn.Close();
            }

            // Default WinForms startup
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}