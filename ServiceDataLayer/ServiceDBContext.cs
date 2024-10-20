using Microsoft.EntityFrameworkCore;
using ServiceDataLayer.Models;

namespace ServiceDataLayer
{
    public class ServiceDBContext : DbContext
    {
        public ServiceDBContext(DbContextOptions<ServiceDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<CarStatus> CarStatuses { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserCars> UserCars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>()
       .HasKey(ur => new { ur.UserId, ur.RoleId });


            modelBuilder.Entity<UserCars>()
                .HasOne(uc => uc.User)
                .WithMany(u => u.UserCars)
                .HasForeignKey(uc => uc.UserId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<UserCars>()
                .HasOne(uc => uc.Car)
                .WithMany(c => c.UserCars)
                .HasForeignKey(uc => uc.CarId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CarStatus>().HasKey(cs => cs.StatusId);

            modelBuilder.Entity<Car>(car =>
            {
                car.HasOne(c => c.User).WithMany(u => u.Cars).OnDelete(DeleteBehavior.NoAction);
            });
        }
    }
}
