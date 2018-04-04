using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTable
{
    //Probably not necessary
    public class Day
    {
        public int Weekday { get; set; }
        public string Name { get; set; }
        public List<Session> Sessions { get; set; }

    }
}
