using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataLayer.Models
{
    public enum ServiceTypeEnum
    {
        OilChange,
        TireRotation,
        BrakeInspection,
        EngineDiagnostic,
        BatteryReplacement,
        TransmissionRepair,
        WheelAlignment,
        AirConditioningService
    }
    public class ServiceType
    {
        public Guid Id { get; set; }
        public ServiceTypeEnum Name { get; set; }

        public decimal ServicePrice { get; set; }
    }
}
