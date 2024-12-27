using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using VehicleRepairShop.Logic;

namespace VehicleRepairShop.Repository
{
    public class DatabaseConnection
    {
        private string instance;
        private string database;
        private string username;
        private string password;
        public DatabaseConnection() 
        {
            this.instance = IniReader.GetValue("DatabaseSettings", "instance");          
            this.database = IniReader.GetValue("DatabaseSettings", "database");
            this.username = IniReader.GetValue("DatabaseSettings", "username");
            this.password = IniReader.GetValue("DatabaseSettings", "password");
        }

        public string GetConnectionString() 
        {
            string connectionString = $"Server={instance};" +
                      $"Database={database};" +
                      $"User ID={username};" +
                      $"Password={password};" +
                      $"Encrypt=True;TrustServerCertificate=True;";

            return connectionString;
        }

    }
}
