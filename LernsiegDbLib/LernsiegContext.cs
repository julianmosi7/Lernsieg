using System;
using Microsoft.EntityFrameworkCore;

namespace LernsiegDbLib
{
    public class LernsiegContext : DbContext
    {
        public LernsiegContext(DbContextOptions<LernsiegContext> options) : base(options) { }
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
                var connectionString = "data source=(LocalDB)\\mssqllocaldb; attachdbfilename=C:\\Users\\mosha\\Documents\\Schule\\5.Klasse\\POS\\Lernsieg\\Lernsieg.mdf;database=Lernsieg;integrated security=True; MultipleActiveResultSets=True";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
