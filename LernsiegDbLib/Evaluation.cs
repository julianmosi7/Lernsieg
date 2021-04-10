using System;
using System.Collections.Generic;

namespace LernsiegDbLib
{
    public class Evaluation
    {
        public int Id { get; set; }
        public int SchoolOrTeacherId { get; set; }
        public int EvaluationType { get; set; }
        public string PhoneNr { get; set; }
        public virtual List<EvaluationItem> EvaluationItems { get; set; }

        public Evaluation()
        {
        }
    }
}
