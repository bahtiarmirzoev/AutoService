using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models
{
    public class CarStatus
    {
        public Guid Id { get; set; }
        public string StatusName { get; set; } = string.Empty;
        public ICollection<Car> Cars { get; set; }
    }
}
