using System;
using System.Collections.Generic;
using System.Text;

namespace LernsiegDbLib
{
    partial class School
    {
        public override string ToString()
        {
            return $"{Id}";
        }
    }

    partial class Teacher
    {
        public override string ToString()
        {
            return $"{Title} {Name}";
        }
    }
}
