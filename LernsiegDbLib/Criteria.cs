using System;
namespace LernsiegDbLib
{
    public class Criteria
    {
        public int Id { get; set; }
        public int EvaluationType { get; set; }
        public int SequenceNr { get; set; }
        public string Description { get; set; }

        public Criteria()
        {
        }
    }
}
