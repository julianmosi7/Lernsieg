using System;
namespace LernsiegDbLib
{
    public class EvaluationItem
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public Criteria Criteria { get; set; }
        public Evaluation Evaluation { get; set; }
    }
}
