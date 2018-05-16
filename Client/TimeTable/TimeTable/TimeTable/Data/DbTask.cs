using System;
using System.Collections.Generic;
using System.Text;
using TimeTable.Common;

namespace TimeTable.Data
{
    public class DbTask : DbLocal
    {
        public DbTask() : base()
        {
            db.CreateTable<Task>();
        }

        public Task Get(int id)
        {
            return db.Get<Task>(id);
        }

        public int Insert(Task t)
        {
            return db.Insert(t);
        }

        public IEnumerable<Task> GetAll()
        {
            return db.Table<Task>();
        }

        public int Update(Task t)
        {
            return db.Update(t);
        }

    }
}
