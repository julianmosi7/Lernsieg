using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LernsiegDbLib
{
    public static class DbSeederExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            int count = 0;
            var location = Assembly.GetExecutingAssembly().Location;
            string dataDirectory = Path.GetDirectoryName(location);
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
                    });
                });

            count = 0;
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
                        SchoolNumber = Int32.Parse(line.Split(";")[0]),
                        Name = line.Split(";")[1],
                        Address = line.Split(";")[2],
                        Country = "at"
                    });
                });     
        }
    }
}
