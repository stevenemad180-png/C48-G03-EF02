using Microsoft.EntityFrameworkCore;
using C48_G03_EF02.config;

namespace C48_G03_EF02
{
    public class eventcontext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<profile> Profiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }

        protected override void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            // Separate Configuration Classes
            modelBuilder.ApplyConfiguration(new ProfileConfig());
            modelBuilder.ApplyConfiguration(new BadgeConfig());

            // Event Configuration - Fluent API Directly
            modelBuilder.Entity<Event>(builder =>
            {
                builder.HasKey(e => e.Id);

                builder.Property(e => e.title)
                    .IsRequired();

                builder.Property(e => e.description)
                    .IsRequired();

                builder.Property(e => e.startDate)
                    .IsRequired();

                builder.Property(e => e.endDate)
                    .IsRequired(false);

                builder.Property(e => e.maximumNumberOfAttendees)
                    .IsRequired();

                // One-to-Many
                builder.HasOne(e => e.organizer)
                    .WithMany(o => o.Events)
                    .HasForeignKey(e => e.organizerId);
            });
        }
       
    }
}