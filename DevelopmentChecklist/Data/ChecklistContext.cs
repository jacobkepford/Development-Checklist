using DevelopmentChecklist.Models;
using Microsoft.EntityFrameworkCore;

namespace DevelopmentChecklist.Data
{
    public class ChecklistContext : DbContext
    {
        public ChecklistContext(DbContextOptions<ChecklistContext> options) : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<AppAssignment> AppAssignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Application>().ToTable("Application");
            modelBuilder.Entity<Developer>().ToTable("Developer");
            modelBuilder.Entity<Note>().ToTable("Note");
            modelBuilder.Entity<AppAssignment>().ToTable("AppAssignment");
        }
    }
}