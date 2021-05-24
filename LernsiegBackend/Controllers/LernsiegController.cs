using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LernsiegBackend.Dtos;
using LernsiegDbLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LernsiegBackend.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LernsiegController : ControllerBase
    {
        private LernsiegService lernsiegService;

        public LernsiegController(LernsiegService lernsiegService)
        {
            this.lernsiegService = lernsiegService;
        }
        
        [HttpGet("{country}")]
        public IEnumerable<SchoolDto> TopSchools(string country)
        {
            return lernsiegService.TopSchools(country).Select(x => new SchoolDto
            {
                Id = x.Id,
                Name = x.Name,
                Country = x.Country,
                SchoolNumber = x.SchoolNumber,
                Address = x.Address, 
            });
        }

        [HttpGet("{country}/{filter}")]
        public IEnumerable<SchoolDto> FindSchools(string country, string filter)
        {
            return lernsiegService.FindSchools(country, filter).Select(x => new SchoolDto
            {
                Id = x.Id,
                Name = x.Name,
                Country = x.Country,
                SchoolNumber = x.SchoolNumber,
                Address = x.Address
            });
        }

        [HttpGet("{id}")]
        public SchoolDto GetSchool(int id)
        {
            School school = lernsiegService.GetSchool(id);
            SchoolDto schoolDto = new SchoolDto
            {
                Id = school.Id,
                Name = school.Name,
                Country = school.Country,
                SchoolNumber = school.SchoolNumber,
                Address = school.Address,
            };
            return schoolDto;
        }

        [HttpGet("{schoolNumber}")]
        public IEnumerable<TeacherDto> GetTeachersOfSchool(int schoolNumber)
        {
            return lernsiegService.GetTeachersOfSchool(schoolNumber).Select(x => new TeacherDto
            {
                Id = x.Id,
                Name = x.Name,
                Title = x.Title
            });
        }

        [HttpGet("{schoolNumber}/{filter}")]

        [HttpGet]
        public IEnumerable<TeacherDto> FindTeachers(int schoolNumber, string filter)
        {
            return lernsiegService.FindTeachers(schoolNumber, filter).Select(x => new TeacherDto
            {
                Id = x.Id,
                Name = x.Name,
                Title = x.Title
            });
        }

        [HttpGet("{id}")]
        public TeacherDto GetTeacher(int id)
        {
            Teacher teacher = lernsiegService.GetTeacher(id);
            TeacherDto teacherDto = new TeacherDto
            {
                Id = teacher.Id,
                Name = teacher.Name,
                Title = teacher.Title
            };
            return teacherDto;
        }

        [HttpGet("{schoolOrTeacherid}/{evaluationType}")]
        public IEnumerable<EvaluationDto> Evaluations(int schoolOrTeacherid, int evaluationType)
        {
            return lernsiegService.Evaluations(schoolOrTeacherid, evaluationType).Select(x => new EvaluationDto
            {
                Id = x.Id,
                SchoolOrTeacherId = x.SchoolOrTeacherId,
                EvaluationType = x.EvaluationType,
                PhoneNr = x.PhoneNr,
                EvaluationItems = x.EvaluationItems
            });
        }

        [HttpGet("{evaluationType}")]
        public IEnumerable<CriteriaDto> Criterias(int evaluationType)
        {
            return lernsiegService.Criterias(evaluationType).Select(x => new CriteriaDto
            {
                Id = x.Id,
                EvaluationType = x.EvaluationType,
                Description = x.Description,
                SequenceNr = x.SequenceNr
            });
        }

        [HttpPost]
        public EvaluationReplyDto SaveEvaluation([FromBody] EvaluationSaveDto data)
        {
            Console.WriteLine(data);
            Evaluation evaluation = new Evaluation
            {
                SchoolOrTeacherId = data.SchoolOrTeacherId,
                EvaluationType = data.EvaluationType,
                PhoneNr = data.PhoneNr,
                EvaluationItems = data.EvaluationItems
            };

            Evaluation evaluationReply = lernsiegService.SaveEvaluation(evaluation);
            return new EvaluationReplyDto
            {
                Id = evaluationReply.Id,
                SchoolOrTeacherId = evaluation.SchoolOrTeacherId,
                EvaluationType = evaluation.EvaluationType,
                PhoneNr = evaluation.PhoneNr
            };
        }
    }
}
