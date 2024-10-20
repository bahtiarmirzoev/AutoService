using ServiceDataLayer.Models.DTOs;
using System;
using System.Collections.Generic;

namespace ServiceDataLayer.Models.DTOs
{
    public class CarStatusDTO
    {
        public Guid StatusId { get; set; }
        public string StatusName { get; set; }  

        
        public ICollection<CarDTO> Cars { get; set; } = new List<CarDTO>();
    }
}
