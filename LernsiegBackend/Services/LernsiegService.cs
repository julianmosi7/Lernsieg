using System;
using System.Collections.Generic;
using System.Linq;
using LernsiegBackend.Dtos;
using LernsiegDbLib;

namespace LernsiegBackend
{
    public class LernsiegService
    {
        private readonly LernsiegContext db;

        public LernsiegService(LernsiegContext db)
        {
            this.db = db;
        }

        public IEnumerable<School> TopSchools(string country)
        {
            return db.Schools.Where(x => x.Country == country).AsEnumerable();
        }

        public IEnumerable<School> FindSchools(string country, string filter)
        {
            return db.Schools.Where(x => x.Country == country)
                .Where(y => (y.Name.Contains(filter)) || (y.Address.Contains(filter))).AsEnumerable();
        }

        public School GetSchool(int id)
        {
            return db.Schools.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Teacher> GetTeachersOfSchool(int schoolNumber)
        {
            return db.Teachers.Where(x => x.SchoolNumber == schoolNumber).AsEnumerable();
        }

        public IEnumerable<Teacher> FindTeachers(int schoolNumber, string filter)
        {
            return db.Teachers.Where(x => x.SchoolNumber == schoolNumber).Where(x => x.Name.Contains(filter)).AsEnumerable();
        }

        public Teacher GetTeacher(int id)
        {
            return db.Teachers.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Evaluation> Evaluations(int schoolOrTeacherId, int evaluationType)
        {
            return db.Evaluations.Where(x => x.SchoolOrTeacherId == schoolOrTeacherId && x.EvaluationType == evaluationType).AsEnumerable();
        } 

        public IEnumerable<Criteria> Criterias(int evaluationType)
        {
            return db.Criterias.Where(x => x.EvaluationType == evaluationType).AsEnumerable();
        }

        public Evaluation SaveEvaluation(Evaluation evaluation)
        {
            try
            {
                db.Evaluations.Add(evaluation);
                foreach (var ev in evaluation.EvaluationItems)
                {
                    db.EvaluationItems.Add(ev);
                }
                db.SaveChanges();
                return db.Evaluations.Where(x => x.PhoneNr == evaluation.PhoneNr).FirstOrDefault();
            }catch(Exception exc)
            {
                Console.WriteLine($"Exception: {exc.Message}");
                return null;
            } 
        }
    }
}
