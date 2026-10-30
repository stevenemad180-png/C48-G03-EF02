using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C48_G03_EF02.config
{
    public class BadgeConfig:IEntityTypeConfiguration<Badge>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Badge> builder)
        {

            builder.HasKey(b => b.BadgeNumber);
            builder.HasOne(a => a.Attendee)
                .WithOne(b => b.Badge)
                .HasForeignKey<Badge>(b => b.AttendeeId);

            builder.Property(b => b.IssueDate)
    .IsRequired();

            builder.Property(b => b.Tier)
                .IsRequired();
        }
    

    }
}
