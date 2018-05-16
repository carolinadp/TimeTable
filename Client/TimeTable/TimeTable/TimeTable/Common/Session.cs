using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TimeTable
{
    [Table("Sessions")]
    public class Session
    {
        [MaxLength(50)]
        public Subject Subject { get; set; }
        []
        public Int64 StartTicks { get; set; }
        public Int64 EndTicks { get; set; }

        public int Weekday { get; set; }
        [PrimaryKey, AutoIncrement]
        public int Id { get; private set; }
        public int SubjectId { get; set; }
    }
}
