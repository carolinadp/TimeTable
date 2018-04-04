using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTable
{
    public class Session
    {
        public Subject Subject { get; set; }
        public TimeSpan Start { get; set; }
        public TimeSpan End { get; set; }

        public int Weekday { get; set; }
    }
}
