namespace ServiceDataLayer.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();  
        public string Username { get; set; } 
        public string Name { get; set; } 
        public string Surname { get; set; }
        public string Email { get; set; } 
        public string Phone { get; set; } 
        public string Password { get; set; }

        public ICollection<Car> Cars { get; set; } = [];
        public ICollection<UserCars> UserCars { get; set; } = [];

        public ICollection<UserRole> UserRoles { get; set; } = [];
    }
}
