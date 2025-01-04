using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CarRepairShop.Classes.Interfaces;
using Newtonsoft.Json;

namespace VehicleRepairShop.Classes.Abstracts
{
    public class Vehicle : IVehicleInterface
    {
        [JsonProperty]
        public int Id { get; private set; }
        [JsonProperty]
        public string VehicleModel { get; private set; }
        [JsonProperty]
        public string VehicleMake { get; private set; }
        [JsonProperty]
        public string PlateNumber { get; private set; }
        [JsonProperty]
        public string RepairStatus { get; private set; }

        [JsonProperty]
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

        public string ToCsvRow()
        {
            string csvRow = "";
            //Id, VehicleModel, VehicleMake, PlateNumber, RepairStatus, EngineType, Transmission, Mileage, Colour
            foreach (PropertyInfo prop in this.GetType().GetProperties())
            {
                csvRow += prop.GetValue(this, null).ToString() + ", ";
            }
            return csvRow;
        }

        public static void SaveAsCsv(List<Vehicle> vehicles, string directory)
        {
            // Create a string array with the lines of text
            string[] rows = new string[vehicles.Count];

            for (int i = 0; i < vehicles.Count; i++)
            {
                rows[i] = vehicles[i].ToCsvRow();
            }


            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(directory, "VehiclesCsv.txt")))
            {
                foreach (string line in rows)
                    outputFile.WriteLine(line);
            }
        }
    }
}
