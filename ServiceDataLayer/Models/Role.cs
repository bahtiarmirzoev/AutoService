using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models
{
    public enum RoleEnum
    {
        User ,
        Admin, 
        SuperAdmin
    }
    public class Role
    {
        public Guid Id { get; set; } 
        public RoleEnum Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
