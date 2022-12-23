using Microsoft.EntityFrameworkCore;
using TrackingDataChanges.Models;

namespace TrackingDataChanges
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            this.Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .ToTable(name: "Students", studentsTable => studentsTable.IsTemporal());
        }

        public DbSet<Student> Students { get; set; }
    }
}
