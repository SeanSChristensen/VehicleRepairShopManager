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

namespace VehicleRepairShop.Forms
{
    public partial class VehicleSpecificationPage : Form
    {
        public VehicleSpecificationPage(Vehicle vehicle)
        {
            InitializeComponent();

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
    }
}
