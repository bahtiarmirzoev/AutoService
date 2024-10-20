using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models.DTOs
{
    public class UserCarsDTO
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CarId { get; set; }

        public UserDTO User { get; set; }
        public CarDTO Car { get; set; }
    }
}
