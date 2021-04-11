using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LernsiegBackend.Dtos
{
    public class EvaluationDto
    {
        public int Id { get; set; }
        public int SchoolOrTeacherId { get; set; }
        public int EvaluationType { get; set; }
        public string PhoneNr { get; set; }
    }
}
