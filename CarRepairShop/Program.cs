using CarRepairShop.Classes.Interfaces;
using NLog;
using VehicleRepairShop.Classes;
using VehicleRepairShop.Classes.Abstracts;
using VehicleRepairShop.Logic;
using VehicleRepairShop.Repository;
using VehicleRepairShop.Repository.Interfaces;

namespace CarRepairShop
{
    internal static class Program
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            _logger.Info("Application Started");
            ApplicationConfiguration.Initialize();
            Application.Run(new SaveAsCsvButton());
            _logger.Info("Application Ended");
        }
    }
}