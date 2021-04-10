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
            try
            {
                int nr = db.Teachers.Count();
                Console.WriteLine($"Nr T: {nr}");
            }catch(Exception exc)
            {

            }
        }

       

        public IEnumerable<School> TopSchools(string country)
        {
            return db.Schools.AsEnumerable();
        }
    }
}
