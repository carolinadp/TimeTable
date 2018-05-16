using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace TimeTable.Common
{
    [Table("Tasks")]
    public class Task
    {
        [PrimaryKey, AutoIncrement, NotNull]
        public Int32 Id { get; set; }
        [MaxLength(100)]
        public String Name { get; set; }
        public Int64 DueDateTicks { get; set; }
        public Int32 SubjectId { get; set; }
        [MaxLength(500)]
        public String Notes { get; set; }

        public Task()
        {

        }

    }
}
