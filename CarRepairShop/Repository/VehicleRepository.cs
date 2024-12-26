﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using VehicleRepairShop.Classes;
using VehicleRepairShop.Classes.Abstracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VehicleRepairShop.Repository
{
    public class VehicleRepository
    {
        private DatabaseConnection _databaseConnection;
        private readonly string _tableName = "Vehicle";
        public VehicleRepository() 
        {
            _databaseConnection = new DatabaseConnection();
        }

        public List<Vehicle> GetVehicles()
        {
            // Define the SQL query
            string query = $"SELECT vehicle_model AS VehicleModel, vehicle_make AS VehicleMake, plate_number AS PlateNumber, repair_status AS RepairStatus, engine_type AS EngineType, transmission AS Transmission, mileage AS Mileage, colour AS Colour FROM {_tableName}";

            // Create and open the connection
            using (SqlConnection connection = new SqlConnection(_databaseConnection.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    //List<Vehicle> vehicles = (List<Vehicle>)connection.Query<Vehicle>(query);
                    // Query and map the result
                    var vehicles = connection.Query<Vehicle, TechnicalSpec, Vehicle>(
                        query,
                        (vehicle, technicalSpec) =>
                        {
                            // Assign the nested object
                            vehicle.GetType().GetProperty("TechnicalSpec").SetValue(vehicle, technicalSpec);
                            return vehicle;
                        },
                        splitOn: "EngineType" // Start mapping TechnicalSpec fields here
                    ).ToList();


                    return vehicles;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return null;
                }
                
            }
        }
    }
}