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
              new CarStatus { Id = Guid.NewGuid(), StatusName = CarStatusEnum.InService},
              new CarStatus { Id = Guid.NewGuid(), StatusName = CarStatusEnum.Repaired },
              new CarStatus { Id = Guid.NewGuid(), StatusName = CarStatusEnum.Available },
              new CarStatus { Id = Guid.NewGuid(), StatusName = CarStatusEnum.OutOfService}
     );

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = Guid.NewGuid(), Name = RoleEnum.User },
                new Role { Id = Guid.NewGuid(), Name = RoleEnum.Admin },
                new Role { Id = Guid.NewGuid() , Name = RoleEnum.SuperAdmin }
            );

            modelBuilder.Entity<ServiceType>().HasData(
                new ServiceType { Id = Guid.NewGuid() ,Name = ServiceTypeEnum.EngineDiagnostic },
                new ServiceType { Id = Guid.NewGuid(), Name = ServiceTypeEnum.TransmissionRepair},
                new ServiceType { Id = Guid.NewGuid(), Name = ServiceTypeEnum.EngineDiagnostic },
                new ServiceType { Id = Guid.NewGuid(), Name = ServiceTypeEnum.BrakeInspection },
                new ServiceType { Id = Guid.NewGuid(), Name = ServiceTypeEnum.AirConditioningService },
                new ServiceType { Id = Guid.NewGuid(), Name = ServiceTypeEnum.TireRotation },
                new ServiceType { Id = Guid.NewGuid(), Name = ServiceTypeEnum.BatteryReplacement },
                new ServiceType { Id = Guid.NewGuid(), Name = ServiceTypeEnum.OilChange }
            );

        }
    }
}
