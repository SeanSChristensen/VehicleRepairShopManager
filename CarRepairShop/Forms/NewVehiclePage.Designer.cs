namespace VehicleRepairShop.Forms
{
    partial class NewVehiclePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            ModelNameLabel = new Label();
            ModelNameTextBox = new TextBox();
            ManufacturerLabel = new Label();
            ManufacturerTextBox = new TextBox();
            PlateNumberLabel = new Label();
            PlateNumberTextBox = new TextBox();
            SeatingCapacityLabel = new Label();
            SeatingCapacityTextBox = new TextBox();
            TruckSpecificationTextBox = new TextBox();
            TruckSpecificationLabel = new Label();
            label1 = new Label();
            AddButton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ColourLabel = new Label();
            ColourTextBox = new TextBox();
            MileageLabel = new Label();
            MileageTextBox = new TextBox();
            TransmissionLabel = new Label();
            TransmissionTextBox = new TextBox();
            EngineTypeLabel = new Label();
            EngineTypeTextBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(155, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ModelNameLabel
            // 
            ModelNameLabel.AutoSize = true;
            ModelNameLabel.Font = new Font("Segoe UI", 11F);
            ModelNameLabel.Location = new Point(6, 19);
            ModelNameLabel.Name = "ModelNameLabel";
            ModelNameLabel.Size = new Size(59, 20);
            ModelNameLabel.TabIndex = 1;
            ModelNameLabel.Text = "Model: ";
            // 
            // ModelNameTextBox
            // 
            ModelNameTextBox.Location = new Point(144, 20);
            ModelNameTextBox.Name = "ModelNameTextBox";
            ModelNameTextBox.Size = new Size(162, 23);
            ModelNameTextBox.TabIndex = 2;
            // 
            // ManufacturerLabel
            // 
            ManufacturerLabel.AutoSize = true;
            ManufacturerLabel.Font = new Font("Segoe UI", 11F);
            ManufacturerLabel.Location = new Point(6, 46);
            ManufacturerLabel.Name = "ManufacturerLabel";
            ManufacturerLabel.Size = new Size(48, 20);
            ManufacturerLabel.TabIndex = 3;
            ManufacturerLabel.Text = "Make:";
            // 
            // ManufacturerTextBox
            // 
            ManufacturerTextBox.Location = new Point(144, 47);
            ManufacturerTextBox.Name = "ManufacturerTextBox";
            ManufacturerTextBox.Size = new Size(162, 23);
            ManufacturerTextBox.TabIndex = 4;
            // 
            // PlateNumberLabel
            // 
            PlateNumberLabel.AutoSize = true;
            PlateNumberLabel.Font = new Font("Segoe UI", 11F);
            PlateNumberLabel.Location = new Point(6, 73);
            PlateNumberLabel.Name = "PlateNumberLabel";
            PlateNumberLabel.Size = new Size(103, 20);
            PlateNumberLabel.TabIndex = 5;
            PlateNumberLabel.Text = "Plate Number:";
            // 
            // PlateNumberTextBox
            // 
            PlateNumberTextBox.Location = new Point(144, 74);
            PlateNumberTextBox.Name = "PlateNumberTextBox";
            PlateNumberTextBox.Size = new Size(162, 23);
            PlateNumberTextBox.TabIndex = 6;
            // 
            // SeatingCapacityLabel
            // 
            SeatingCapacityLabel.AutoSize = true;
            SeatingCapacityLabel.Font = new Font("Segoe UI", 11F);
            SeatingCapacityLabel.Location = new Point(6, 103);
            SeatingCapacityLabel.Name = "SeatingCapacityLabel";
            SeatingCapacityLabel.Size = new Size(123, 20);
            SeatingCapacityLabel.TabIndex = 7;
            SeatingCapacityLabel.Text = "Seating Capacity:";
            SeatingCapacityLabel.Visible = false;
            // 
            // SeatingCapacityTextBox
            // 
            SeatingCapacityTextBox.Location = new Point(143, 103);
            SeatingCapacityTextBox.Name = "SeatingCapacityTextBox";
            SeatingCapacityTextBox.Size = new Size(162, 23);
            SeatingCapacityTextBox.TabIndex = 8;
            SeatingCapacityTextBox.Visible = false;
            // 
            // TruckSpecificationTextBox
            // 
            TruckSpecificationTextBox.Location = new Point(144, 103);
            TruckSpecificationTextBox.Name = "TruckSpecificationTextBox";
            TruckSpecificationTextBox.Size = new Size(162, 23);
            TruckSpecificationTextBox.TabIndex = 10;
            TruckSpecificationTextBox.Visible = false;
            // 
            // TruckSpecificationLabel
            // 
            TruckSpecificationLabel.AutoSize = true;
            TruckSpecificationLabel.Font = new Font("Segoe UI", 11F);
            TruckSpecificationLabel.Location = new Point(6, 103);
            TruckSpecificationLabel.Name = "TruckSpecificationLabel";
            TruckSpecificationLabel.Size = new Size(136, 20);
            TruckSpecificationLabel.TabIndex = 9;
            TruckSpecificationLabel.Text = "Truck Specification:";
            TruckSpecificationLabel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 11;
            label1.Text = "Vehicle Type:";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(12, 365);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 12;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ModelNameLabel);
            groupBox1.Controls.Add(ModelNameTextBox);
            groupBox1.Controls.Add(TruckSpecificationTextBox);
            groupBox1.Controls.Add(ManufacturerLabel);
            groupBox1.Controls.Add(TruckSpecificationLabel);
            groupBox1.Controls.Add(ManufacturerTextBox);
            groupBox1.Controls.Add(SeatingCapacityTextBox);
            groupBox1.Controls.Add(PlateNumberLabel);
            groupBox1.Controls.Add(SeatingCapacityLabel);
            groupBox1.Controls.Add(PlateNumberTextBox);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 142);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vehicle Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ColourLabel);
            groupBox2.Controls.Add(ColourTextBox);
            groupBox2.Controls.Add(MileageLabel);
            groupBox2.Controls.Add(MileageTextBox);
            groupBox2.Controls.Add(TransmissionLabel);
            groupBox2.Controls.Add(TransmissionTextBox);
            groupBox2.Controls.Add(EngineTypeLabel);
            groupBox2.Controls.Add(EngineTypeTextBox);
            groupBox2.Location = new Point(12, 193);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(319, 166);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Technical Specifications";
            // 
            // ColourLabel
            // 
            ColourLabel.AutoSize = true;
            ColourLabel.Font = new Font("Segoe UI", 11F);
            ColourLabel.Location = new Point(6, 110);
            ColourLabel.Name = "ColourLabel";
            ColourLabel.Size = new Size(47, 20);
            ColourLabel.TabIndex = 17;
            ColourLabel.Text = "Colur:";
            // 
            // ColourTextBox
            // 
            ColourTextBox.Location = new Point(144, 111);
            ColourTextBox.Name = "ColourTextBox";
            ColourTextBox.Size = new Size(162, 23);
            ColourTextBox.TabIndex = 18;
            // 
            // MileageLabel
            // 
            MileageLabel.AutoSize = true;
            MileageLabel.Font = new Font("Segoe UI", 11F);
            MileageLabel.Location = new Point(6, 78);
            MileageLabel.Name = "MileageLabel";
            MileageLabel.Size = new Size(66, 20);
            MileageLabel.TabIndex = 15;
            MileageLabel.Text = "Mileage:";
            // 
            // MileageTextBox
            // 
            MileageTextBox.Location = new Point(144, 79);
            MileageTextBox.Name = "MileageTextBox";
            MileageTextBox.Size = new Size(162, 23);
            MileageTextBox.TabIndex = 16;
            // 
            // TransmissionLabel
            // 
            TransmissionLabel.AutoSize = true;
            TransmissionLabel.Font = new Font("Segoe UI", 11F);
            TransmissionLabel.Location = new Point(6, 48);
            TransmissionLabel.Name = "TransmissionLabel";
            TransmissionLabel.Size = new Size(96, 20);
            TransmissionLabel.TabIndex = 13;
            TransmissionLabel.Text = "Transmission:";
            // 
            // TransmissionTextBox
            // 
            TransmissionTextBox.Location = new Point(144, 49);
            TransmissionTextBox.Name = "TransmissionTextBox";
            TransmissionTextBox.Size = new Size(162, 23);
            TransmissionTextBox.TabIndex = 14;
            // 
            // EngineTypeLabel
            // 
            EngineTypeLabel.AutoSize = true;
            EngineTypeLabel.Font = new Font("Segoe UI", 11F);
            EngineTypeLabel.Location = new Point(6, 19);
            EngineTypeLabel.Name = "EngineTypeLabel";
            EngineTypeLabel.Size = new Size(92, 20);
            EngineTypeLabel.TabIndex = 11;
            EngineTypeLabel.Text = "Engine Type:";
            // 
            // EngineTypeTextBox
            // 
            EngineTypeTextBox.Location = new Point(144, 20);
            EngineTypeTextBox.Name = "EngineTypeTextBox";
            EngineTypeTextBox.Size = new Size(162, 23);
            EngineTypeTextBox.TabIndex = 12;
            // 
            // NewVehiclePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 402);
            Controls.Add(groupBox2);
            Controls.Add(AddButton);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(groupBox1);
            Name = "NewVehiclePage";
            Text = "New Vehicle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label ModelNameLabel;
        private TextBox ModelNameTextBox;
        private Label ManufacturerLabel;
        private TextBox ManufacturerTextBox;
        private Label PlateNumberLabel;
        private TextBox PlateNumberTextBox;
        private Label SeatingCapacityLabel;
        private TextBox SeatingCapacityTextBox;
        private TextBox TruckSpecificationTextBox;
        private Label TruckSpecificationLabel;
        private Label label1;
        private Button AddButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label EngineTypeLabel;
        private TextBox EngineTypeTextBox;
        private Label MileageLabel;
        private TextBox MileageTextBox;
        private Label TransmissionLabel;
        private TextBox TransmissionTextBox;
        private Label ColourLabel;
        private TextBox ColourTextBox;
    }
}