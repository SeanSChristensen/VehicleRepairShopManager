using Microsoft.IdentityModel.Tokens;
using VehicleRepairShop.Classes;
using VehicleRepairShop.Classes.Abstracts;
using VehicleRepairShop.Repository;
using VehicleRepairShop.Repository.Interfaces;

namespace VehicleRepairShop.Forms
{
    public partial class NewVehiclePage : Form
    {
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
            IRepository<Vehicle> vehicleRepository = new VehicleRepository();

            List<TextBox> requiredInputFields = TechnicalSpecificationsGroupBox.Controls.OfType<TextBox>()
                .Concat(VehicleInformationGroupBox.Controls.OfType<TextBox>())
                .ToList();

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select vehicle type");
                return;
            }


            if (comboBox1.SelectedItem == "Car") 
            {
                requiredInputFields.Remove(TruckSpecificationTextBox);
            }

            if (comboBox1.SelectedItem == "Truck")
            {
                requiredInputFields.Remove(SeatingCapacityTextBox);
            }


            foreach (var textBox in requiredInputFields)
            {
                if (textBox.Text.IsNullOrEmpty() )
                {
                    MessageBox.Show("Please complete form");
                    return;
                }
            }

            vehicleRepository.Add(new Vehicle(ModelNameTextBox.Text, ManufacturerTextBox.Text, PlateNumberTextBox.Text, new TechnicalSpec(EngineTypeTextBox.Text, TransmissionTextBox.Text, Int32.Parse(MileageTextBox.Text), ColourTextBox.Text)));


            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
