using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepairShop.Classes.Abstracts;

namespace VehicleRepairShop.Classes
{
    public class Truck : Vehicle
    {
        private string _truckSpecification;

        public Truck(string truckSpecification, string vehicleModel, string vehicleMake, string plateNumber, TechnicalSpec technicalSpec) : base(vehicleModel, vehicleMake, plateNumber, technicalSpec)
        {
            _truckSpecification = truckSpecification;
        }
    }
}
