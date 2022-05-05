using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst.Entities.Configurations
{
    public class StudentEfConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(e => e.IdStudent).HasName("Student_pk");
            builder.Property(e => e.IdStudent).UseIdentityColumn();

            builder.Property(e => e.FirstName).IsRequired().HasMaxLength(30);
            builder.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            builder.Property(e => e.IndexNumber).IsRequired().HasMaxLength(10);

            builder.ToTable("Student");
        }
    }
}
