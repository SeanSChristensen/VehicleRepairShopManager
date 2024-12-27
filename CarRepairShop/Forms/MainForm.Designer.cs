namespace CarRepairShop
{
    partial class MainForm
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
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            SuspendLayout();
            // 
            // DataGridView
            // 
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Location = new Point(12, 51);
            DataGridView.Name = "DataGridView";
            DataGridView.ReadOnly = true;
            DataGridView.RowHeadersVisible = false;
            DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView.Size = new Size(776, 250);
            DataGridView.TabIndex = 0;
            DataGridView.SelectionChanged += DataGridView_SelectionChanged;
            // 
            // NewVehicleButton
            // 
            NewVehicleButton.Location = new Point(12, 316);
            NewVehicleButton.Name = "NewVehicleButton";
            NewVehicleButton.Size = new Size(178, 23);
            NewVehicleButton.TabIndex = 2;
            NewVehicleButton.Text = "New Vehicle";
            NewVehicleButton.UseVisualStyleBackColor = true;
            NewVehicleButton.Click += NewVehicleButton_Click;
            // 
            // FilterLabel
            // 
            FilterLabel.AutoSize = true;
            FilterLabel.Font = new Font("Segoe UI", 11F);
            FilterLabel.Location = new Point(12, 9);
            FilterLabel.Name = "FilterLabel";
            FilterLabel.Size = new Size(42, 20);
            FilterLabel.TabIndex = 3;
            FilterLabel.Text = "Filter";
            // 
            // FilterComboBox
            // 
            FilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(60, 10);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(121, 23);
            FilterComboBox.TabIndex = 4;
            // 
            // FilterTextBox
            // 
            FilterTextBox.Location = new Point(187, 10);
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.Size = new Size(143, 23);
            FilterTextBox.TabIndex = 5;
            FilterTextBox.TextChanged += FilterTextBox_TextChanged;
            // 
            // InspectButton
            // 
            InspectButton.Location = new Point(713, 316);
            InspectButton.Name = "InspectButton";
            InspectButton.Size = new Size(75, 23);
            InspectButton.TabIndex = 6;
            InspectButton.Text = "Inspect";
            InspectButton.UseVisualStyleBackColor = true;
            InspectButton.Click += InspectButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InspectButton);
            Controls.Add(FilterTextBox);
            Controls.Add(FilterComboBox);
            Controls.Add(FilterLabel);
            Controls.Add(NewVehicleButton);
            Controls.Add(DataGridView);
            Name = "MainForm";
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
    }
}
