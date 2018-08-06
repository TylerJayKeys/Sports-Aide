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

            string createQuery = @"CREATE TABLE IF NOT EXISTS [players] (
                                    [player_id] INTEGER  NOT NULL
                                    , [firstname] text NOT NULL
                                    , [lastname] text NOT NULL
                                    , [picture] image NULL
                                    , [team_id] bigint  NOT NULL
                                    , [active] bigint DEFAULT 1  NOT NULL
                                    , [goals] bigint DEFAULT 0  NOT NULL
                                    , CONSTRAINT [sqlite_master_PK_players] PRIMARY KEY ([player_id])
                                    );";

            SQLiteConnection.CreateFile("sportsaide.db3");
            using (SQLiteConnection conn = new SQLiteConnection("data source=sportsaide.db3"))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    conn.Open();
                    cmd.CommandText = createQuery;
                    cmd.ExecuteNonQuery();
                };
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}