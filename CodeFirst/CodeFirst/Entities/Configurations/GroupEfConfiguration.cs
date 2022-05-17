using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Entities.Configurations
{
    public class GroupEfConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(e => e.IdGroup).HasName("Group_pk");
            builder.Property(e => e.IdGroup).UseIdentityColumn();

            builder.Property(e => e.Name).IsRequired().HasMaxLength(15);

            builder.ToTable("Group");
        }
    }
}
