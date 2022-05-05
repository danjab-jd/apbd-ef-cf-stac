using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace CodeFirst.Entities.Configurations
{
    public class GroupEfConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(e => e.IdGroup).HasName("Group_pk");
            builder.Property(e => e.IdGroup).UseIdentityColumn();

            builder.Property(e => e.Name).IsRequired().HasMaxLength(10);

            //builder.HasIndex(e=>e.Name).IsUnique();

            builder.ToTable("Group");
        }
    }
}
