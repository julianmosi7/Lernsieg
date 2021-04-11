using System;
using System.Collections.Generic;

namespace LernsiegDbLib
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int SchoolNumber { get; set; }
        public string Address { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
