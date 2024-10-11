using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ServiceDataLayer.Models
{
    public class ServiceDBContext : DbContext
    {
        public ServiceDBContext(DbContextOptions<ServiceDBContext> options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<CarStatus> CarStatuses { get; set; }

        public DbSet<ServiceType> ServiceTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                .HasOne(c => c.User)
                .WithMany(u => u.Cars)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<Car>()
                .HasOne(c => c.Status)
                .WithMany(s => s.Cars)
                .HasForeignKey(c => c.StatusId);

            modelBuilder.Entity<User>()
                .HasOne<Role>(u => u.Role)
                .WithMany(r => r.Users);

            modelBuilder.Entity<Car>()
                .Property(c => c.Make)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Car>()
                .Property(c => c.Model)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Username)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(150);

            modelBuilder.Entity<CarStatus>().HasData(
              new CarStatus { Id = Guid.NewGuid(), StatusName = "Pending" },
              new CarStatus { Id = Guid.NewGuid(), StatusName = "InProgress" },
              new CarStatus { Id = Guid.NewGuid(), StatusName = "Completed" }
     );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "User" },
                new Role { Id = 2 ,Name = "Admin" },
                new Role { Id = 3 , Name = "SuperAdmin" }
            );

            modelBuilder.Entity<ServiceType>().HasData(
                new ServiceType { Id = 1, ServiceName = "Oil Change" },
                new ServiceType { Id = 2, ServiceName = "Tire Rotation" },
                new ServiceType { Id = 3, ServiceName = "Brake Inspection" },
                new ServiceType { Id = 4, ServiceName = "Engine Diagnostic" },
                new ServiceType { Id = 5, ServiceName = "Battery Replacement" },
                new ServiceType { Id = 6, ServiceName = "Transmission Repair" },
                new ServiceType { Id = 7, ServiceName = "Wheel Alignment" },
                new ServiceType { Id = 8, ServiceName = "Air Conditioning Service" }
            );

        }
    }
}
