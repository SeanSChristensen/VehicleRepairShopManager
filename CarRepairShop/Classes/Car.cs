using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VehicleRepairShop.Classes.Abstracts;

namespace VehicleRepairShop.Classes
{
    public class Car : Vehicle
    {
        [JsonProperty]
        public int SeatingCapacity { get; private set; }
        public Car(int seatingCapacity, string vehicleModel, string vehicleMake, string plateNumber, TechnicalSpec technicalSpec) : base(vehicleModel, vehicleMake, plateNumber, technicalSpec)
        {
            this.SeatingCapacity = seatingCapacity;
        }
    }
}
