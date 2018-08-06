using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;


namespace SportsAide
{
    public static class Player
    {
        public static void Add(string name)
        {
            // Add to DB, call Sync then refresh list.
            // Alternatively have list saved locally then manually sync.
            throw new NotImplementedException();
        }

        public static void Remove(string name)
        {
            throw new NotImplementedException();
        }

        public static Array Get(string name) // Find object for database item??
        {
            throw new NotImplementedException();
        }

        public static void Load(string db)
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
