using System;
namespace LernsiegDbLib
{
    public class EvaluationItem
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public virtual Criteria Criteria { get; set; }
        public virtual Evaluation Evaluation { get; set; }
        public EvaluationItem()
        {
        }
    }
}
