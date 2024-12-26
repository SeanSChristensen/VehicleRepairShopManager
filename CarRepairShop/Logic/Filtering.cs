using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRepairShop.Classes.Abstracts;

namespace VehicleRepairShop.Logic
{
    public class Filtering
    {
        public static IEnumerable<Vehicle> FilterMake(IEnumerable<Vehicle> vehicleList, string vehicleMake)
        {
            if (vehicleMake == "")
            {
                return vehicleList;
            }
            else
            {
                var newVehicleList = new List<Vehicle>();
                foreach (var vehicle in vehicleList)
                {
                    if (vehicle.VehicleMake.StartsWith(vehicleMake))
                    {
                        newVehicleList.Add(vehicle);
                    }
                }
                return newVehicleList;
            }
        }

        public static IEnumerable<Vehicle> FilterModel(IEnumerable<Vehicle> vehicleList, string vehicleModel)
        {
            if (vehicleModel == "")
            {
                return vehicleList;
            }
            else
            {
                var newVehicleList = new List<Vehicle>();
                foreach (var vehicle in vehicleList)
                {
                    if (vehicle.VehicleModel.StartsWith(vehicleModel))
                    {
                        newVehicleList.Add(vehicle);
                    }
                }
                return newVehicleList;
            }
        }
    }
}
