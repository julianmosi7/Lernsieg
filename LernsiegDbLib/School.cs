using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LernsiegDbLib
{
    public partial class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
    }
}
