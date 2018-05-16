using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace TimeTable.Common
{
    [Table("Tasks")]
    public class Task
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public long DueDateTicks { get; set; }
        public int SubjectId { get; set; }
        [MaxLength(500)]
        public string Notes { get; set; }
    }
}
