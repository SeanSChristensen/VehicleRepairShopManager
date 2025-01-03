using Newtonsoft.Json;
using VehicleRepairShop.Classes;
using VehicleRepairShop.Classes.Abstracts;
using VehicleRepairShop.Forms;
using VehicleRepairShop.Logic;
using VehicleRepairShop.Repository;
using VehicleRepairShop.Repository.Interfaces;

namespace CarRepairShop
{
    public partial class SaveAsCsvButton : Form
    {
        private List<Vehicle> _vehicles;

        private List<Vehicle> _displayedVehicles = new List<Vehicle>();
        public SaveAsCsvButton()
        {
            RefreshVehicles();
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

        private void RefreshVehicles()
        {
            IRepository<Vehicle> vehicleRepository = new VehicleRepository();
            _vehicles = (List<Vehicle>)vehicleRepository.GetAll();
            _displayedVehicles = _vehicles;
        }

        private void NewVehicleButton_Click(object sender, EventArgs e)
        {
            IRepository<Vehicle> vehicleRepository = new VehicleRepository();

            using (NewVehiclePage promptForm = new NewVehiclePage())
            {
                if (promptForm.ShowDialog() == DialogResult.OK)
                {
                    _vehicles = (List<Vehicle>)vehicleRepository.GetAll();
                    _displayedVehicles = _vehicles;
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
            RefreshVehicles();
            RefreshDataGridView();
        }

        private void JsonImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog JsonImportFileDialogue = new OpenFileDialog();
            JsonImportFileDialogue.InitialDirectory = Application.StartupPath + "Sample\\";
            JsonImportFileDialogue.ShowDialog();

            Car car = JsonDeserialization.ImportCarFromJson(JsonImportFileDialogue.FileName);
            IRepository<Vehicle> vehicleRepository = new VehicleRepository();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to import this car into the database", "Car from Json", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                vehicleRepository.Add(car);
            }
            RefreshVehicles();
            RefreshDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                Vehicle.SaveAsCsv(_vehicles, fbd.SelectedPath);
            }

        }
    }
}
