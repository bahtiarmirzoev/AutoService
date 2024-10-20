using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models.DTOs
{
    public class ServiceTypeDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal ServicePrice { get; set; }
    }

}
