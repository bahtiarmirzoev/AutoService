using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models
{
    public class UserRole
    {
        public Guid RoleId { get; set; }  // Foreign Key
        public Guid UserId { get; set; }  // Foreign Key

        public Role Role { get; set; }
        public User User { get; set; }

    }
}
