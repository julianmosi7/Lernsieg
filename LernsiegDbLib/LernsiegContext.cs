using System;
using Microsoft.EntityFrameworkCore;

namespace LernsiegDbLib
{
    public class LernsiegContext : DbContext
    {
        public LernsiegContext() { }

        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<EvaluationItem> EvaluationItems { get; set; }
        public DbSet<Criteria> Criterias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "data source=(LocalDB)\\mssqllocaldb; attachdbfilename=/Users/julianmosi/Documents/School/5.Klasse/POS/Lernsieg;database=Lernsieg;integrated security=True; MultipleActiveResultSets=True";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
