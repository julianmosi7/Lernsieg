using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LernsiegDbLib
{
    public partial class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int SchoolNumber { get; set; }
        public School School { get; set; }
    }
}
