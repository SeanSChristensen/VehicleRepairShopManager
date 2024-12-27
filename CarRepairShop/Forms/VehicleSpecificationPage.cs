using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRepairShop.Classes.Abstracts;
using VehicleRepairShop.Repository;

namespace VehicleRepairShop.Forms
{
    public partial class VehicleSpecificationPage : Form
    {
        private Vehicle _vehicle;
        public VehicleSpecificationPage(Vehicle vehicle)
        {
            InitializeComponent();

            _vehicle = vehicle;

            VehicleIdLabel.Text = vehicle.Id.ToString();

            VehicleModelLabel.Text = vehicle.VehicleModel;
            VehicleMakeLabel.Text = vehicle.VehicleMake;
            PlateNumberLabel.Text = vehicle.PlateNumber;
            RepairStatusLabel.Text = vehicle.RepairStatus;

            EngineTypeLabel.Text = vehicle.TechnicalSpec.EngineType;
            TransmissionLabel.Text = vehicle.TechnicalSpec.Transmission;
            MileageLabel.Text = vehicle.TechnicalSpec.Mileage.ToString();
            ColourLabel.Text = vehicle.TechnicalSpec.Colour;


            if (vehicle.RepairStatus == "Not Finished")
            {
                RepairStatusLabel.ForeColor = Color.Red;
            }
            else
            {
                RepairStatusLabel.ForeColor = Color.Green;
            }


        }

        private void FinishRepairStatusButton_Click(object sender, EventArgs e)
        {
            var vehicleRepository = new VehicleRepository();
            vehicleRepository.UpdateVehicleRepairStatus(_vehicle.Id.ToString());
            RepairStatusLabel.Text = "Finished";
            RepairStatusLabel.ForeColor = Color.Green;
        }
    }
}
