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
        public Guid RoleId { get; set; }
        public RoleEnum RoleName { get; set; }
    }
}
