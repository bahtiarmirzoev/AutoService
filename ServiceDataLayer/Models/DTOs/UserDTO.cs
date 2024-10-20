using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models.DTOs
{
    public class UserDTO
    {
      
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

   



    }
}
