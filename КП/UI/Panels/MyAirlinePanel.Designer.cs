namespace КП.UI.Panels
{
    partial class MyAirlinePanel
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            sortFieldLabel = new Label();
            searchLabel = new Label();
            aircraftsListDataGrid = new DataGridView();
            airlineLabel = new Label();
            addressLabel = new Label();
            aircraftListLabel = new Label();
            airlineFlightsDataGrid = new DataGridView();
            searchFlightTextBox = new TextBox();
            searchFlightsLabel = new Label();
            searchTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)aircraftsListDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airlineFlightsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // sortFieldLabel
            // 
            sortFieldLabel.AutoSize = true;
            sortFieldLabel.Location = new Point(385, 379);
            sortFieldLabel.Name = "sortFieldLabel";
            sortFieldLabel.Size = new Size(124, 20);
            sortFieldLabel.TabIndex = 66;
            sortFieldLabel.Text = "Сортировать по:";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(488, 160);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(59, 20);
            searchLabel.TabIndex = 61;
            searchLabel.Text = "Искать:";
            // 
            // aircraftsListDataGrid
            // 
            aircraftsListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            aircraftsListDataGrid.Location = new Point(133, 25);
            aircraftsListDataGrid.Margin = new Padding(3, 4, 3, 4);
            aircraftsListDataGrid.Name = "aircraftsListDataGrid";
            aircraftsListDataGrid.RowHeadersWidth = 51;
            aircraftsListDataGrid.Size = new Size(624, 507);
            aircraftsListDataGrid.TabIndex = 60;
            // 
            // airlineLabel
            // 
            airlineLabel.AutoSize = true;
            airlineLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            airlineLabel.Location = new Point(681, 123);
            airlineLabel.Name = "airlineLabel";
            airlineLabel.Size = new Size(245, 41);
            airlineLabel.TabIndex = 69;
            airlineLabel.Text = "Авиакомпания:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            addressLabel.Location = new Point(704, 191);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(116, 41);
            addressLabel.TabIndex = 70;
            addressLabel.Text = "Адрес:";
            // 
            // aircraftListLabel
            // 
            aircraftListLabel.AutoSize = true;
            aircraftListLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aircraftListLabel.Location = new Point(571, 316);
            aircraftListLabel.Name = "aircraftListLabel";
            aircraftListLabel.Size = new Size(525, 41);
            aircraftListLabel.TabIndex = 71;
            aircraftListLabel.Text = "Самолёты и рейсы авиакомпании:";
            // 
            // airlineFlightsDataGrid
            // 
            airlineFlightsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            airlineFlightsDataGrid.Location = new Point(237, 363);
            airlineFlightsDataGrid.Margin = new Padding(3, 4, 3, 4);
            airlineFlightsDataGrid.Name = "airlineFlightsDataGrid";
            airlineFlightsDataGrid.RowHeadersWidth = 51;
            airlineFlightsDataGrid.Size = new Size(624, 507);
            airlineFlightsDataGrid.TabIndex = 72;
            // 
            // searchFlightTextBox
            // 
            searchFlightTextBox.Location = new Point(411, 56);
            searchFlightTextBox.Margin = new Padding(3, 4, 3, 4);
            searchFlightTextBox.Name = "searchFlightTextBox";
            searchFlightTextBox.Size = new Size(155, 27);
            searchFlightTextBox.TabIndex = 74;
            // 
            // searchFlightsLabel
            // 
            searchFlightsLabel.AutoSize = true;
            searchFlightsLabel.Location = new Point(411, 25);
            searchFlightsLabel.Name = "searchFlightsLabel";
            searchFlightsLabel.Size = new Size(59, 20);
            searchFlightsLabel.TabIndex = 73;
            searchFlightsLabel.Text = "Искать:";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(488, 191);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(155, 27);
            searchTextBox.TabIndex = 62;
            // 
            // MyAirlinePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(searchFlightTextBox);
            Controls.Add(searchFlightsLabel);
            Controls.Add(airlineFlightsDataGrid);
            Controls.Add(aircraftListLabel);
            Controls.Add(addressLabel);
            Controls.Add(airlineLabel);
            Controls.Add(sortFieldLabel);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(aircraftsListDataGrid);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MyAirlinePanel";
            Size = new Size(1025, 703);
            SizeChanged += MyAirlinePanel_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)aircraftsListDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)airlineFlightsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label sortFieldLabel;
        private Label searchLabel;
        private DataGridView aircraftsListDataGrid;
        private Label airlineLabel;
        private Label addressLabel;
        private Label aircraftListLabel;
        private DataGridView airlineFlightsDataGrid;
        private TextBox searchFlightTextBox;
        private Label searchFlightsLabel;
        private TextBox searchTextBox;
    }
}
