using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LernsiegDbLib
{
    public class LernsiegContext : DbContext
    {
        public LernsiegContext(DbContextOptions<LernsiegContext> options) : base(options) { }
        public LernsiegContext() { }

        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Evaluation> Evaluations { get; set; }
        public virtual DbSet<EvaluationItem> EvaluationItems { get;  set; }
        public virtual DbSet<Criteria> Criterias { get; set; }

        private static LernsiegContext CreateContext()
        {
            var config = new ConfigurationBuilder().Build();
            var optionsBuilder = new DbContextOptionsBuilder<LernsiegContext>();
            var db = new LernsiegContext(optionsBuilder.Options);
            db.Database.Migrate();
            return db;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "data source=(LocalDB)\\mssqllocaldb;attachdbfilename=C:\\Users\\mosha\\Documents\\Schule\\5.Klasse\\POS\\Lernsieg\\Lernsieg.mdf;database=Lernsieg;integrated security=True; MultipleActiveResultSets=True";
                optionsBuilder.UseSqlite(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
