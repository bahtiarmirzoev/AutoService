using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models.DTOs
{
    public class RoleDTO
    {
        public Guid RoleId { get; set; }
        public string RoleName { get; set; }

        // Если нужно передавать список пользователей, связанных с этой ролью
        public ICollection<UserDTO> Users { get; set; } = new List<UserDTO>();
    }
}
