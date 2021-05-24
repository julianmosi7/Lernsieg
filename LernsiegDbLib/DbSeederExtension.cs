using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace LernsiegDbLib
{
    public static class DbSeederExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            int count = 0;
            var location = Assembly.GetExecutingAssembly().Location;
            string dataDirectory = Path.GetDirectoryName(location);
            string fullPathSchools = Path.Combine(dataDirectory, "schools.csv");
            Console.WriteLine($"DbSeed using file {fullPathSchools}");
            File.ReadAllLines(fullPathSchools)
                .Skip(1)
                .ToList()
                .ForEach(line =>
                {
                    count = count + 1;
                    modelBuilder.Entity<School>().HasData(new School
                    {
                        Id = count,
                        Name = line.Split(";")[1],
                        Address = line.Split(";")[2],
                        //SchoolNumber = Int32.Parse(line.Split(";")[0]),
                        Country = "at"
                    });
                });

            count = 0;
            string fullPathTeachers = Path.Combine(dataDirectory, "teachers.csv");
            Console.WriteLine($"DbSeed using file {fullPathTeachers}");
            File.ReadAllLines(fullPathTeachers)
                .Skip(1)
                .ToList()
                .ForEach(line =>
                {
                    count = count + 1;
                    modelBuilder.Entity<Teacher>().HasData(new Teacher
                    {
                        Id = count,
                        Name = line.Split(";")[0],
                        Title = line.Split(";")[1],
                        SchoolNumber = Int32.Parse(line.Split(";")[2])
                    });
                });

           
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 1, EvaluationType = 1, SequenceNr = 1, Description = "Klassenzimmer" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 2, EvaluationType = 1, SequenceNr = 2, Description = "Lehrangebot" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 3, EvaluationType = 1, SequenceNr = 3, Description = "Stimmung" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 4, EvaluationType = 1, SequenceNr = 4, Description = "Motivationsfähigkeit" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 5, EvaluationType = 1, SequenceNr = 5, Description = "Sportanlage" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 6, EvaluationType = 1, SequenceNr = 6, Description = "Mensa oder Kantine" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 7, EvaluationType = 1, SequenceNr = 7, Description = "Supplierungen" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 8, EvaluationType = 1, SequenceNr = 8, Description = "Bibliothek" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 9, EvaluationType = 1, SequenceNr = 9, Description = "Sauberkeit" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 10, EvaluationType = 1, SequenceNr = 10, Description = "Neue Medien" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 11, EvaluationType = 1, SequenceNr = 12, Description = "Veranstaltungen" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 12, EvaluationType = 1, SequenceNr = 12, Description = "Fridays for Future" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 13, EvaluationType = 2, SequenceNr = 1, Description = "Unterricht" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 14, EvaluationType = 2, SequenceNr = 2, Description = "Fairness" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 15, EvaluationType = 2, SequenceNr = 3, Description = "Respekt" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 16, EvaluationType = 2, SequenceNr = 4, Description = "Motivationsfähigkeit" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 17, EvaluationType = 2, SequenceNr = 5, Description = "Geduld" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 18, EvaluationType = 2, SequenceNr = 6, Description = "Vorbereitung" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 19, EvaluationType = 2, SequenceNr = 7, Description = "Durchsetzungsfähigkeit" });
            modelBuilder.Entity<Criteria>().HasData(new Criteria { Id = 20, EvaluationType = 2, SequenceNr = 8, Description = "Pünktlichkeit" });

            modelBuilder.Entity<Evaluation>().HasData(new Evaluation { Id = 1, SchoolOrTeacherId = 6, EvaluationType = 1, PhoneNr = "8907872346" });
            modelBuilder.Entity<Evaluation>().HasData(new Evaluation { Id = 2, SchoolOrTeacherId = 401417, EvaluationType = 1, PhoneNr = "069911343415" });
           
        }
    }
}
