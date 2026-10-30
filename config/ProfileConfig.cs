using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48_G03_EF02.config
{
    public class ProfileConfig : IEntityTypeConfiguration<profile>
    {
        public void Configure(EntityTypeBuilder<profile> builder)
        {
            builder.HasOne(o=>o.org)
                .WithOne(p => p.orgProfile)
                .HasForeignKey<profile>(p => p.orgId);

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Biography)
                .IsRequired(false);

            builder.Property(p => p.Website)
                .IsRequired(false);

            builder.Property(p => p.Logo)
                .IsRequired(false);
        }

    }
}
