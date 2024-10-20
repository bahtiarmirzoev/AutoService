using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models
{

    public enum CarStatusEnum
    {
        Available,
        InService,
        Repaired,
        OutOfService,
        Pending,
        Completed
    }
    public class CarStatus
    {
        public Guid StatusId { get; set; }
        public CarStatusEnum StatusName { get; set; } 
        public ICollection<Car> Cars { get; set; }
    }
    
}
