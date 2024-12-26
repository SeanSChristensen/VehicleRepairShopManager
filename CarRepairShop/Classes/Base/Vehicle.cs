using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRepairShop.Classes.Interfaces;

namespace VehicleRepairShop.Classes.Abstracts
{
    public class Vehicle : IVehicleInterface
    {
        public string VehicleModel { get; private set; }
        public string VehicleMake { get; private set; }
        public string PlateNumber { get; private set; }
        public string RepairStatus { get; private set; }

        public TechnicalSpec TechnicalSpec { get; private set; }

        public Vehicle(string vehicleModel, string vehicleMake, string plateNumber, TechnicalSpec technicalSpec)
        {
            VehicleModel = vehicleModel;
            VehicleMake = vehicleMake;
            PlateNumber = plateNumber;
            TechnicalSpec = technicalSpec;
            RepairStatus = "Not Finished";
        }

        public Vehicle() { }

        public void UpdateRepairStatus(bool isFinished)
        {
            if (isFinished == true)
            {
                RepairStatus = "Finished";
            }
            else
            {
                RepairStatus = "Not Finished";
            }
        }
    }
}
