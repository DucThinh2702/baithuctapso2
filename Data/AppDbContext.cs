using Microsoft.EntityFrameworkCore;
using TrainingSystem.API.Models;

namespace TrainingSystem.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<ServiceStats> ServiceStats { get; set; }
        public DbSet<AssignmentUsage> AssignmentUsage { get; set; }
        public DbSet<DeviceAssignmentCount> DeviceAssignmentCount { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ServiceStats>()
               .HasNoKey()
               .ToView("view_servicestats"); // tên viết thường
           modelBuilder.Entity<AssignmentUsage>()
                .HasNoKey()
                .ToView("view_assignmentusage");


            modelBuilder.Entity<DeviceAssignmentCount>()
     .HasNoKey()
     .ToView("view_deviceassignmentcount");

        }

    }

}
