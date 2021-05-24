using LernsiegDbLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LernsiegBackend.Dtos
{
    public class EvaluationItemDto
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public Criteria Criteria { get; set; }
        public Evaluation Evaluation { get; set; }
    }
}
