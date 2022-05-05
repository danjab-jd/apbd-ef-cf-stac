using CodeFirst.Entities.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CodeFirst.Entities
{
    public class UniversityContext : DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<StudentGroup> StudentGroups { get; set; }

        public UniversityContext()
        { }

        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options) 
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(StudentEfConfiguration).GetTypeInfo().Assembly);
        }

    }
}
