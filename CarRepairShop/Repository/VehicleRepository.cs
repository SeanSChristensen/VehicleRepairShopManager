using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using NLog;
using VehicleRepairShop.Classes;
using VehicleRepairShop.Classes.Abstracts;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace VehicleRepairShop.Repository
{
    public class VehicleRepository
    {
        private DatabaseConnection _databaseConnection;
        private readonly string _tableName = "Vehicle";

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public VehicleRepository() 
        {
            _databaseConnection = new DatabaseConnection();
        }

        public List<Vehicle> GetVehicles()
        {
            // Define the SQL query
            string query = $"SELECT id AS Id, vehicle_model AS VehicleModel, vehicle_make AS VehicleMake, plate_number AS PlateNumber, repair_status AS RepairStatus, engine_type AS EngineType, transmission AS Transmission, mileage AS Mileage, colour AS Colour FROM {_tableName}";

            // Create and open the connection
            using (SqlConnection connection = new SqlConnection(_databaseConnection.GetConnectionString()))
            {
                try
                {
                    connection.Open();
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
                    connection.Close();

                    _logger.Info($"SELECT Query to {_tableName}, Count: " + vehicles.Count);
                    return vehicles;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return null;
                }
            }
        }

        public void InsertVehicle(Vehicle vehicle)
        {
            // Define the SQL query
            string query = $"INSERT INTO {_tableName} (vehicle_model, vehicle_make, plate_number, repair_status, engine_type, transmission, mileage, colour) VALUES " +
                $"('{vehicle.VehicleModel}', '{vehicle.VehicleMake}', '{vehicle.PlateNumber}', '{vehicle.RepairStatus}', '{vehicle.TechnicalSpec.EngineType}', '{vehicle.TechnicalSpec.Transmission}', '{vehicle.TechnicalSpec.Mileage}', '{vehicle.TechnicalSpec.Colour}');";

            // Create and open the connection
            using (SqlConnection connection = new SqlConnection(_databaseConnection.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    connection.Execute(query);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                connection.Close();
                _logger.Info($"INSERT Query to {_tableName}: " + query);
            }
        }

        public void UpdateVehicleRepairStatus(string id)
        {
            // Define the SQL query
            string query = $"UPDATE Vehicle SET repair_status = 'Finished' WHERE id = {id}";

            // Create and open the connection
            using (SqlConnection connection = new SqlConnection(_databaseConnection.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    connection.Execute(query);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                connection.Close();
                _logger.Info($"UPDATE Query to {_tableName}, ID: " + id);
            }
        }
    }
}
