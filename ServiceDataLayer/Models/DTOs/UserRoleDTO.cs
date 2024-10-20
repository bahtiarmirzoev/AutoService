using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models.DTOs
{
    public class UserRoleDTO
    {
        public Guid RoleId { get; set; }
        public Guid UserId { get; set; }
    }
}
