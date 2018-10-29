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
                                    , [active] bigint DEFAULT 1 NOT NULL
                                    , [goals] bigint DEFAULT 0 NOT NULL
                                    , [position] text DEFAULT 'Midfielder' NOT NULL
                                    , [notes] text DEFAULT 'None' NOT NULL
                                    , [potw] bigint DEFAULT 0 NOT NULL
                                    , [distance] bigint DEFAULT 0 NOT NULL
                                    , [playtime] bigint DEFAULT 0 NOT NULL
                                    , [saved] bigint DEFAULT 0 NOT NULL
                                    , [interceptions] bigint DEFAULT 0 NOT NULL
                                    , [tackles] bigint DEFAULT 0 NOT NULL
                                    , [fouls] bigint DEFAULT 0 NOT NULL
                                    , [offsides] bigint DEFAULT 0 NOT NULL
                                    , [assists] bigint DEFAULT 0 NOT NULL
                                    , CONSTRAINT [sqlite_master_PK_players] PRIMARY KEY ([player_id])
                                    );

                                    CREATE TABLE IF NOT EXISTS [stats] (
                                      [game_id] INTEGER NOT NULL
                                    , [player_id] INTEGER DEFAULT 0 NOT NULL
                                    , [distance] INTEGER DEFAULT 0 NOT NULL
                                    , [goals] INTEGER DEFAULT 0 NOT NULL
                                    , [playtime] INTEGER DEFAULT 0 NOT NULL
                                    , [saved] INTEGER DEFAULT 0 NOT NULL
                                    , [interceptions] INTEGER DEFAULT 0 NOT NULL
                                    , [tackles] INTEGER DEFAULT 0 NOT NULL
                                    , [fouls] INTEGER DEFAULT 0 NOT NULL
                                    , [offsides] INTEGER DEFAULT 0 NOT NULL
                                    , [assists] INTEGER DEFAULT 0 NOT NULL
                                    , FOREIGN KEY(player_id) REFERENCES players(player_id)
                                    , FOREIGN KEY(game_id) REFERENCES games(game_id)
                                    );

                                    CREATE TABLE IF NOT EXISTS [games] (
                                      [game_id] INTEGER NOT NULL
                                    , [date] STRING NOT NULL
                                    , CONSTRAINT [sqlite_master_PK_games] PRIMARY KEY ([game_id])
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