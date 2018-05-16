using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using SQLite;

namespace TimeTable.Data
{
    public abstract class DbLocal
    {
        protected string dbPath;
        protected SQLiteConnection db;
        protected DbLocal()
        {
            dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                "timetable.db3");
            db = new SQLiteConnection(dbPath);
        }
    }
}
