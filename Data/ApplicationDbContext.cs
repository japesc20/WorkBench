using System;
using Microsoft.EntityFrameworkCore;
using backend.Models.Calculators;
using backend.Models.Inspection;
using backend.Models.StackUp;
using backend.Models.Traveler;


namespace backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // Inspection
        public DbSet<Checklist> Checklists { get; set; }
        public DbSet<ChecklistItem> ChecklistItems { get; set; }

        // StackUp
        public DbSet<StackUp> StackUps { get; set; }
        public DbSet<StackUpComponent> StackUpComponent { get; set; }

        // Calculators
        public DbSet<FeedsAndSpeedsCalculator> Calculators { get; set; }

        // Traveler
        public DbSet<Traveler> Travelers { get; set; }
        public DbSet<TravelerOperation> TravelerOperations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply separate configs for clarity
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}