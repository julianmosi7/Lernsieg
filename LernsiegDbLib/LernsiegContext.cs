using System;
using Microsoft.EntityFrameworkCore;

namespace LernsiegDbLib
{
    public class LernsiegContext : DbContext
    {
        public LernsiegContext(DbContextOptions<LernsiegContext> options) : base(options) { }
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<EvaluationItem> EvaluationItems { get; set; }
        public DbSet<Criteria> Criterias { get; set; }
    }
}
