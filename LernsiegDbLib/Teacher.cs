using System;
using System.Collections.Generic;

namespace LernsiegDbLib
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public virtual School School { get; set; }
    }
}
