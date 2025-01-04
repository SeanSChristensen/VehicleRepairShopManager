using Dapper;
using Microsoft.Data.SqlClient;
using NLog;
using System.Data;
using VehicleRepairShop.Classes;
using VehicleRepairShop.Classes.Abstracts;
using VehicleRepairShop.Repository.Interfaces;

namespace VehicleRepairShop.Repository
{
    public class VehicleRepository: IRepository<Vehicle>
    {
        private DatabaseConnection _databaseConnection;
        private readonly string _tableName = "Vehicle";

        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public VehicleRepository() 
        {
            _databaseConnection = new DatabaseConnection();
        }

        public IEnumerable<Vehicle> GetAll()
        {
            DatabaseCheck();

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

        public void Add(Vehicle vehicle)
        {
            DatabaseCheck();

            // Create and open the connection
            using (SqlConnection connection = new SqlConnection(_databaseConnection.GetConnectionString()))
            {
                SqlCommand sqlCommand = new SqlCommand($@"INSERT INTO {_tableName} (vehicle_model, vehicle_make, plate_number, repair_status, engine_type, transmission, mileage, colour) VALUES (@vehicle_model, @vehicle_make, @plate_number, @repair_status, @engine_type, @transmission, @mileage, @colour);",
                    connection);
                sqlCommand.Parameters.Add("@vehicle_model", SqlDbType.VarChar).Value = vehicle.VehicleModel;
                sqlCommand.Parameters.Add("@vehicle_make", SqlDbType.VarChar).Value = vehicle.VehicleMake;
                sqlCommand.Parameters.Add("@plate_number", SqlDbType.VarChar).Value = vehicle.PlateNumber;
                sqlCommand.Parameters.Add("@repair_status", SqlDbType.VarChar).Value = vehicle.RepairStatus;
                sqlCommand.Parameters.Add("@engine_type", SqlDbType.VarChar).Value = vehicle.TechnicalSpec.EngineType;
                sqlCommand.Parameters.Add("@transmission", SqlDbType.VarChar).Value = vehicle.TechnicalSpec.Transmission;
                sqlCommand.Parameters.Add("@mileage", SqlDbType.Int).Value = vehicle.TechnicalSpec.Mileage;
                sqlCommand.Parameters.Add("@colour", SqlDbType.VarChar).Value = vehicle.TechnicalSpec.Colour;

                try
                {
                    connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                connection.Close();
                _logger.Info($"INSERT Query to {_tableName}: " + sqlCommand.ToString());
            }
        }

        public void Update(string id, string column, string value)
        {
            DatabaseCheck();

            // Define the SQL query
            string query = $"UPDATE Vehicle SET {column} = '{value}' WHERE id = {id}";

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
                _logger.Info($"UPDATE Query to {_tableName}, {column} updated to {value} where ID is " + id);
            }
        }

        public void CreateTable()
        {
            // Define the SQL query
            string query = $"CREATE TABLE master.dbo.Vehicle(\r\n\t[id] [int] IDENTITY(1,1) NOT NULL,\r\n\t[vehicle_model] [varchar](50) NOT NULL,\r\n\t[vehicle_make] [varchar](50) NOT NULL,\r\n\t[plate_number] [varchar](50) NOT NULL,\r\n\t[repair_status] [varchar](50) NOT NULL,\r\n\t[engine_type] [varchar](50) NOT NULL,\r\n\t[transmission] [varchar](50) NOT NULL,\r\n\t[mileage] [int] NOT NULL,\r\n\t[colour] [varchar](50) NOT NULL,\r\n CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED \r\n(\r\n\t[id] ASC\r\n)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]\r\n) ON [PRIMARY]";

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
                _logger.Info($"CREATE TABLE Query, Table: {_tableName} was created");
            }
        }

        public bool TableExists()
        {
            // Define the SQL query
            string query = $"IF EXISTS( SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{_tableName}') SELECT 1 ELSE SELECT 0";

            // Create and open the connection
            using (SqlConnection connection = new SqlConnection(_databaseConnection.GetConnectionString()))
            {
                try
                {
                    connection.Open();
                    connection.Execute(query);
                    int exists = (int)connection.ExecuteScalar(query);
                    connection.Close();
                    if (exists == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return false;
                }
            }
        }

        private void DatabaseCheck()
        {
            if(TableExists() == false)
            {
                CreateTable();
            }
        }
    }
}
