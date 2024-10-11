using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Car> Cars { get; set; }


    }

}


