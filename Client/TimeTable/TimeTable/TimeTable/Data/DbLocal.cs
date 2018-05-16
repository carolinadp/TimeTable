using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SQLite;

namespace TimeTable.Data
{
    public class DbLocal
    {
        protected string dbPath;
        public SQLiteConnection db;
        protected static DbLocal instance;
        protected DbLocal()
        {
            dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                "timetable.db3");
            db = new SQLiteConnection(dbPath);
        }

        public static DbLocal GetInstance()
        {
            if (instance == null)
            {
                instance = new DbLocal();
            }
            return instance;
        }

    }
}
