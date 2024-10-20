using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models
{
    public class UserCars
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public Guid CarId { get; set; }

        public User User { get; set; }
        public Car Car { get; set; }
    }
}
