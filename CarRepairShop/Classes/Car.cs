using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepairShop.Classes.Abstracts;

namespace VehicleRepairShop.Classes
{
    public class Car : Vehicle
    {
        public int seatingCapacity { get; private set; }
        public Car(int seatingCapacity, string vehicleModel, string vehicleMake, string plateNumber, TechnicalSpec technicalSpec) : base(vehicleModel, vehicleMake, plateNumber, technicalSpec)
        {
            this.seatingCapacity = seatingCapacity;
        }
    }
}
