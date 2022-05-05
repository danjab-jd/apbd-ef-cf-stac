using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CodeFirst.Entities.Configurations
{
    public class StudentGroupEfConfiguration : IEntityTypeConfiguration<StudentGroup>
    {
        public void Configure(EntityTypeBuilder<StudentGroup> builder)
        {
            builder.HasKey(e => new { e.IdGroup, e.IdStudent }).HasName("StudentGroup_pk");

            builder.Property(e => e.AddedAt).IsRequired().HasDefaultValue(DateTime.Now);

            builder.HasOne(e => e.IdGroupNavigation)
                .WithMany(e => e.StudentGroups)
                .HasForeignKey(e => e.IdGroup)
                .HasConstraintName("StudentGroup_Group")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(e => e.IdStudentNavigation)
                .WithMany(e => e.StudentGroups)
                .HasForeignKey(e => e.IdStudent)
                .HasConstraintName("StudentGroup_Student")
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.ToTable("Student_Group");
        }
    }
}
