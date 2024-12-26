using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleRepairShop.Classes;
using VehicleRepairShop.Classes.Abstracts;

namespace VehicleRepairShop.Forms
{
    public partial class NewVehiclePage : Form
    {
        public Vehicle createdVehicle;

        private static List<Control> _carFormElements = new List<Control>();
        private List<Control> _truckFormElements = new List<Control>();
        public NewVehiclePage()
        {
            InitializeComponent();

            comboBox1.Items.Add("Car");
            comboBox1.Items.Add("Truck");

            _carFormElements.Add(SeatingCapacityLabel);
            _carFormElements.Add(SeatingCapacityTextBox);

            _truckFormElements.Add(TruckSpecificationLabel);
            _truckFormElements.Add(TruckSpecificationTextBox);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Car")
            {
                foreach (Control control in _carFormElements)
                {
                    _carFormElements.ForEach(control => control.Visible = true);
                    _truckFormElements.ForEach(control => control.Visible = false);
                }
            }
            if (comboBox1.SelectedItem == "Truck")
            {
                _carFormElements.ForEach(control => control.Visible = false);
                _truckFormElements.ForEach(control => control.Visible = true);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == "Car")
            {
                createdVehicle = new Car(Int32.Parse(SeatingCapacityTextBox.Text), ModelNameTextBox.Text, ManufacturerTextBox.Text, PlateNumberTextBox.Text, new TechnicalSpec("","",0,""));
            }
            if (comboBox1.SelectedItem == "Truck")
            {
                createdVehicle = new Truck(TruckSpecificationTextBox.Text, ModelNameTextBox.Text, ManufacturerTextBox.Text, PlateNumberTextBox.Text, new TechnicalSpec(EngineTypeTextBox.Text, TransmissionTextBox.Text, Int32.Parse(MileageTextBox.Text) , ColourTextBox.Text));
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
