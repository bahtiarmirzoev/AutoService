using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models
{
    public class Car
    {
        public Guid Id { get; set; }

        public string Make { get; set; } 

        public string Model { get; set; } 

        public string LicensePlate { get; set; } 

        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid StatusId { get; set; }
        public CarStatus Status { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
