namespace CarRepairShop
{
    partial class SaveAsCsvButton
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridView = new DataGridView();
            NewVehicleButton = new Button();
            FilterLabel = new Label();
            FilterComboBox = new ComboBox();
            FilterTextBox = new TextBox();
            InspectButton = new Button();
            JsonImportButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(17, 85);
            DataGridView.Margin = new Padding(4, 5, 4, 5);
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.RowHeadersVisible = false;
            DataGridView.RowHeadersWidth = 62;
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.Size = new Size(1109, 417);
            DataGridView.TabIndex = 0;
            DataGridView.SelectionChanged += DataGridView_SelectionChanged;
            // 
            // NewVehicleButton
            // 
            NewVehicleButton.Location = new Point(17, 527);
            NewVehicleButton.Margin = new Padding(4, 5, 4, 5);
            NewVehicleButton.Name = "NewVehicleButton";
            NewVehicleButton.Size = new Size(254, 38);
            NewVehicleButton.TabIndex = 2;
            NewVehicleButton.Text = "New Vehicle";
            NewVehicleButton.UseVisualStyleBackColor = true;
            NewVehicleButton.Click += NewVehicleButton_Click;
            // 
            // FilterLabel
            // 
            FilterLabel.AutoSize = true;
            FilterLabel.Font = new Font("Segoe UI", 11F);
            FilterLabel.Location = new Point(17, 15);
            FilterLabel.Margin = new Padding(4, 0, 4, 0);
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Size = new Size(61, 30);
            FilterLabel.TabIndex = 3;
            FilterLabel.Text = "Filter";
            // 
            // FilterComboBox
            // 
            FilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(86, 17);
            FilterComboBox.Margin = new Padding(4, 5, 4, 5);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(171, 33);
            FilterComboBox.TabIndex = 4;
            // 
            // FilterTextBox
            // 
            FilterTextBox.Location = new Point(267, 17);
            FilterTextBox.Margin = new Padding(4, 5, 4, 5);
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.Size = new Size(203, 31);
            FilterTextBox.TabIndex = 5;
            FilterTextBox.TextChanged += FilterTextBox_TextChanged;
            // 
            // InspectButton
            // 
            InspectButton.Location = new Point(1019, 527);
            InspectButton.Margin = new Padding(4, 5, 4, 5);
            InspectButton.Name = "InspectButton";
            InspectButton.Size = new Size(107, 38);
            InspectButton.TabIndex = 6;
            InspectButton.Text = "Inspect";
            InspectButton.UseVisualStyleBackColor = true;
            InspectButton.Click += InspectButton_Click;
            // 
            // JsonImportButton
            // 
            JsonImportButton.Location = new Point(280, 527);
            JsonImportButton.Margin = new Padding(4, 5, 4, 5);
            JsonImportButton.Name = "JsonImportButton";
            JsonImportButton.Size = new Size(217, 38);
            JsonImportButton.TabIndex = 7;
            JsonImportButton.Text = "Import Car From JSON";
            JsonImportButton.UseVisualStyleBackColor = true;
            JsonImportButton.Click += JsonImportButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(505, 527);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(141, 38);
            button1.TabIndex = 8;
            button1.Text = "Save As CSV";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SaveAsCsvButton
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(button1);
            Controls.Add(JsonImportButton);
            Controls.Add(InspectButton);
            Controls.Add(FilterTextBox);
            Controls.Add(FilterComboBox);
            Controls.Add(FilterLabel);
            Controls.Add(NewVehicleButton);
            Controls.Add(DataGridView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SaveAsCsvButton";
            Text = "Repair List";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataGridView;
        private Button NewVehicleButton;
        private Label FilterLabel;
        private ComboBox FilterComboBox;
        private TextBox FilterTextBox;
        private Button InspectButton;
        private Button JsonImportButton;
        private Button button1;
    }
}
