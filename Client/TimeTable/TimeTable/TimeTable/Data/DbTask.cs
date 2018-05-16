using System;
using System.Collections.Generic;
using System.Text;
using TimeTable.Common;

namespace TimeTable.Data
{
    public class DbTask
    {
        public DbTask()
        {
            DbLocal.GetInstance().db.CreateTable<Task>();
        }

        public Task Get(int id)
        {
            return DbLocal.GetInstance().db.Get<Task>(id);
        }

        public int Insert(Task t)
        {
            return DbLocal.GetInstance().db.Insert(t);
        }

        public IEnumerable<Task> GetAll()
        {
            return DbLocal.GetInstance().db.Table<Task>();
        }

        public int Update(Task t)
        {
            return DbLocal.GetInstance().db.Update(t);
        }

    }
}
