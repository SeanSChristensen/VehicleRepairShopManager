using System.Windows.Forms;
using VehicleRepairShop.Classes;
using VehicleRepairShop.Classes.Abstracts;
using VehicleRepairShop.Forms;
using VehicleRepairShop.Logic;
using VehicleRepairShop.Repository;
using static System.Windows.Forms.DataFormats;

namespace CarRepairShop
{
    public partial class MainForm : Form
    {
        private List<Vehicle> _vehicles;

        private List<Vehicle> _displayedVehicles = new List<Vehicle>();
        public MainForm()
        {
            var vehicleRepository = new VehicleRepository();

            _vehicles = vehicleRepository.GetVehicles();
            _displayedVehicles = _vehicles;

            InitializeComponent();
            RefreshDataGridView();
            FilterComboBox.Items.Add("Vehicle Make");
            FilterComboBox.Items.Add("Vehicle Model");
        }

        private void RefreshDataGridView()
        {
            DataGridView.DataSource = null;
            DataGridView.DataSource = _displayedVehicles;
            DataGridView.Columns["TechnicalSpec"].Visible = false;
        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            foreach (var vehicle in _displayedVehicles)
            {
                vehicle.UpdateRepairStatus(true);
            }
            RefreshDataGridView();
        }

        private void NewVehicleButton_Click(object sender, System.EventArgs e)
        {
            using (NewVehiclePage promptForm = new NewVehiclePage())
            {
                if (promptForm.ShowDialog() == DialogResult.OK)
                {
                    _vehicles.Add(promptForm.createdVehicle);
                    RefreshDataGridView();
                }
            }
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FilterComboBox.Text == "Vehicle Make")
            {
                _displayedVehicles = (List<Vehicle>)Filtering.FilterMake(_vehicles, FilterTextBox.Text);
                RefreshDataGridView();
            }

            if (FilterComboBox.Text == "Vehicle Model")
            {
                _displayedVehicles = (List<Vehicle>)Filtering.FilterModel(_vehicles, FilterTextBox.Text);
                RefreshDataGridView();
            }
        }

        private void InspectButton_Click(object sender, EventArgs e)
        {
            var selectedIndex = DataGridView.CurrentCell.RowIndex;
            VehicleSpecificationPage myForm = new VehicleSpecificationPage(_displayedVehicles[selectedIndex]);
            this.Hide();
            myForm.ShowDialog();
            this.Show();
        }
    }
}
