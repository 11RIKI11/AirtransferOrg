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
            resetFiltersBtn = new Button();
            sortAscBtn = new Button();
            sortFieldLabel = new Label();
            sortLabel = new Label();
            sortDescBtn = new Button();
            searchTextBox = new TextBox();
            searchLabel = new Label();
            aircraftsListDataGrid = new DataGridView();
            sortFieldSelect = new ComboBox();
            airlineLabel = new Label();
            addressLabel = new Label();
            aircraftListLabel = new Label();
            airlineFlightsDataGrid = new DataGridView();
            flightsResetFiltersBtn = new Button();
            flightSortAscBtn = new Button();
            flightSortFieldLabel = new Label();
            sortFlightLabel = new Label();
            flightsSortDesc = new Button();
            sortFlightsComboBox = new ComboBox();
            searchFlightTextBox = new TextBox();
            searchFlightsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)aircraftsListDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)airlineFlightsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // resetFiltersBtn
            // 
            resetFiltersBtn.Location = new Point(434, 242);
            resetFiltersBtn.Name = "resetFiltersBtn";
            resetFiltersBtn.Size = new Size(136, 41);
            resetFiltersBtn.TabIndex = 68;
            resetFiltersBtn.Text = "Сбросить фильтры";
            resetFiltersBtn.UseVisualStyleBackColor = true;
            // 
            // sortAscBtn
            // 
            sortAscBtn.Location = new Point(116, 170);
            sortAscBtn.Name = "sortAscBtn";
            sortAscBtn.Size = new Size(136, 41);
            sortAscBtn.TabIndex = 67;
            sortAscBtn.Text = "По возрастанию";
            sortAscBtn.UseVisualStyleBackColor = true;
            // 
            // sortFieldLabel
            // 
            sortFieldLabel.AutoSize = true;
            sortFieldLabel.Location = new Point(337, 284);
            sortFieldLabel.Name = "sortFieldLabel";
            sortFieldLabel.Size = new Size(98, 15);
            sortFieldLabel.TabIndex = 66;
            sortFieldLabel.Text = "Сортировать по:";
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(360, 198);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(76, 15);
            sortLabel.TabIndex = 65;
            sortLabel.Text = "Сортировка:";
            // 
            // sortDescBtn
            // 
            sortDescBtn.Location = new Point(176, 215);
            sortDescBtn.Name = "sortDescBtn";
            sortDescBtn.Size = new Size(136, 41);
            sortDescBtn.TabIndex = 64;
            sortDescBtn.Text = "По убыванию";
            sortDescBtn.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(427, 143);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(136, 23);
            searchTextBox.TabIndex = 62;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(427, 120);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(48, 15);
            searchLabel.TabIndex = 61;
            searchLabel.Text = "Искать:";
            // 
            // aircraftsListDataGrid
            // 
            aircraftsListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            aircraftsListDataGrid.Location = new Point(116, 19);
            aircraftsListDataGrid.Name = "aircraftsListDataGrid";
            aircraftsListDataGrid.Size = new Size(546, 380);
            aircraftsListDataGrid.TabIndex = 60;
            // 
            // sortFieldSelect
            // 
            sortFieldSelect.AutoCompleteCustomSource.AddRange(new string[] { "Названию модели", "Вместимости сомолёта" });
            sortFieldSelect.FormattingEnabled = true;
            sortFieldSelect.Items.AddRange(new object[] { "Название модели", "Вместимость" });
            sortFieldSelect.Location = new Point(207, 145);
            sortFieldSelect.Name = "sortFieldSelect";
            sortFieldSelect.Size = new Size(136, 23);
            sortFieldSelect.TabIndex = 63;
            // 
            // airlineLabel
            // 
            airlineLabel.AutoSize = true;
            airlineLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            airlineLabel.Location = new Point(596, 92);
            airlineLabel.Name = "airlineLabel";
            airlineLabel.Size = new Size(199, 32);
            airlineLabel.TabIndex = 69;
            airlineLabel.Text = "Авиакомпания:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            addressLabel.Location = new Point(616, 143);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(94, 32);
            addressLabel.TabIndex = 70;
            addressLabel.Text = "Адрес:";
            // 
            // aircraftListLabel
            // 
            aircraftListLabel.AutoSize = true;
            aircraftListLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            aircraftListLabel.Location = new Point(500, 237);
            aircraftListLabel.Name = "aircraftListLabel";
            aircraftListLabel.Size = new Size(427, 32);
            aircraftListLabel.TabIndex = 71;
            aircraftListLabel.Text = "Самолёты и рейсы авиакомпании:";
            // 
            // airlineFlightsDataGrid
            // 
            airlineFlightsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            airlineFlightsDataGrid.Location = new Point(207, 272);
            airlineFlightsDataGrid.Name = "airlineFlightsDataGrid";
            airlineFlightsDataGrid.Size = new Size(546, 380);
            airlineFlightsDataGrid.TabIndex = 72;
            // 
            // flightsResetFiltersBtn
            // 
            flightsResetFiltersBtn.Location = new Point(367, 141);
            flightsResetFiltersBtn.Name = "flightsResetFiltersBtn";
            flightsResetFiltersBtn.Size = new Size(136, 41);
            flightsResetFiltersBtn.TabIndex = 80;
            flightsResetFiltersBtn.Text = "Сбросить фильтры";
            flightsResetFiltersBtn.UseVisualStyleBackColor = true;
            // 
            // flightSortAscBtn
            // 
            flightSortAscBtn.Location = new Point(49, 69);
            flightSortAscBtn.Name = "flightSortAscBtn";
            flightSortAscBtn.Size = new Size(136, 41);
            flightSortAscBtn.TabIndex = 79;
            flightSortAscBtn.Text = "По возрастанию";
            flightSortAscBtn.UseVisualStyleBackColor = true;
            // 
            // flightSortFieldLabel
            // 
            flightSortFieldLabel.AutoSize = true;
            flightSortFieldLabel.Location = new Point(270, 183);
            flightSortFieldLabel.Name = "flightSortFieldLabel";
            flightSortFieldLabel.Size = new Size(98, 15);
            flightSortFieldLabel.TabIndex = 78;
            flightSortFieldLabel.Text = "Сортировать по:";
            // 
            // sortFlightLabel
            // 
            sortFlightLabel.AutoSize = true;
            sortFlightLabel.Location = new Point(293, 97);
            sortFlightLabel.Name = "sortFlightLabel";
            sortFlightLabel.Size = new Size(76, 15);
            sortFlightLabel.TabIndex = 77;
            sortFlightLabel.Text = "Сортировка:";
            // 
            // flightsSortDesc
            // 
            flightsSortDesc.Location = new Point(109, 114);
            flightsSortDesc.Name = "flightsSortDesc";
            flightsSortDesc.Size = new Size(136, 41);
            flightsSortDesc.TabIndex = 76;
            flightsSortDesc.Text = "По убыванию";
            flightsSortDesc.UseVisualStyleBackColor = true;
            // 
            // sortFlightsComboBox
            // 
            sortFlightsComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Названию модели", "Вместимости сомолёта" });
            sortFlightsComboBox.FormattingEnabled = true;
            sortFlightsComboBox.Items.AddRange(new object[] { "Время отправления", "Время прибытия", "Статус", "Аэропрт отправления", "Аэропорт прибытия" });
            sortFlightsComboBox.Location = new Point(140, 44);
            sortFlightsComboBox.Name = "sortFlightsComboBox";
            sortFlightsComboBox.Size = new Size(136, 23);
            sortFlightsComboBox.TabIndex = 75;
            // 
            // searchFlightTextBox
            // 
            searchFlightTextBox.Location = new Point(360, 42);
            searchFlightTextBox.Name = "searchFlightTextBox";
            searchFlightTextBox.Size = new Size(136, 23);
            searchFlightTextBox.TabIndex = 74;
            // 
            // searchFlightsLabel
            // 
            searchFlightsLabel.AutoSize = true;
            searchFlightsLabel.Location = new Point(360, 19);
            searchFlightsLabel.Name = "searchFlightsLabel";
            searchFlightsLabel.Size = new Size(48, 15);
            searchFlightsLabel.TabIndex = 73;
            searchFlightsLabel.Text = "Искать:";
            // 
            // MyAirlinePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(flightsResetFiltersBtn);
            Controls.Add(flightSortAscBtn);
            Controls.Add(flightSortFieldLabel);
            Controls.Add(sortFlightLabel);
            Controls.Add(flightsSortDesc);
            Controls.Add(sortFlightsComboBox);
            Controls.Add(searchFlightTextBox);
            Controls.Add(searchFlightsLabel);
            Controls.Add(airlineFlightsDataGrid);
            Controls.Add(aircraftListLabel);
            Controls.Add(addressLabel);
            Controls.Add(airlineLabel);
            Controls.Add(resetFiltersBtn);
            Controls.Add(sortAscBtn);
            Controls.Add(sortFieldLabel);
            Controls.Add(sortLabel);
            Controls.Add(sortDescBtn);
            Controls.Add(sortFieldSelect);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(aircraftsListDataGrid);
            Name = "MyAirlinePanel";
            Size = new Size(897, 527);
            SizeChanged += MyAirlinePanel_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)aircraftsListDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)airlineFlightsDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetFiltersBtn;
        private Button sortAscBtn;
        private Label sortFieldLabel;
        private Label sortLabel;
        private Button sortDescBtn;
        private TextBox searchTextBox;
        private Label searchLabel;
        private DataGridView aircraftsListDataGrid;
        private ComboBox sortFieldSelect;
        private Label airlineLabel;
        private Label addressLabel;
        private Label aircraftListLabel;
        private DataGridView airlineFlightsDataGrid;
        private Button flightsResetFiltersBtn;
        private Button flightSortAscBtn;
        private Label flightSortFieldLabel;
        private Label sortFlightLabel;
        private Button flightsSortDesc;
        private ComboBox sortFlightsComboBox;
        private TextBox searchFlightTextBox;
        private Label searchFlightsLabel;
    }
}
