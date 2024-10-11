using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models
{
    public class ServiceType
    {
        public int Id { get; set; }
        public string ServiceName { get; set; } = string.Empty;

        public decimal ServicePrice { get; set; }
    }
}
