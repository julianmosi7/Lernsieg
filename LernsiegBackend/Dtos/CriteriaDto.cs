using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LernsiegBackend.Dtos
{
    public class CriteriaDto
    {
        public int Id { get; set; }
        public int EvaluationType { get; set; }
        public int SequenceNr { get; set; }
        public string Description { get; set; }
    }
}
