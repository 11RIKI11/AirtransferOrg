namespace КП.UI.Panels
{
    partial class FlightListPanel
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
            flightListDataGrid = new DataGridView();
            showMyFlightsBtn = new Button();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            showAllFlights = new Button();
            sortFieldSelect = new ComboBox();
            sortDescBtn = new Button();
            sortAscBtn = new Button();
            sortLabel = new Label();
            sortFieldLabel = new Label();
            departureDateSelectCalendar = new MonthCalendar();
            departureDateselectLabel = new Label();
            resetFiltersBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)flightListDataGrid).BeginInit();
            SuspendLayout();
            // 
            // flightListDataGrid
            // 
            flightListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            flightListDataGrid.Location = new Point(251, 158);
            flightListDataGrid.Name = "flightListDataGrid";
            flightListDataGrid.Size = new Size(938, 561);
            flightListDataGrid.TabIndex = 24;
            // 
            // showMyFlightsBtn
            // 
            showMyFlightsBtn.Location = new Point(535, 167);
            showMyFlightsBtn.Name = "showMyFlightsBtn";
            showMyFlightsBtn.Size = new Size(136, 41);
            showMyFlightsBtn.TabIndex = 25;
            showMyFlightsBtn.Text = "Мои рейсы";
            showMyFlightsBtn.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(725, 121);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(48, 15);
            searchLabel.TabIndex = 26;
            searchLabel.Text = "Искать:";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(725, 144);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(136, 23);
            searchTextBox.TabIndex = 27;
            // 
            // showAllFlights
            // 
            showAllFlights.Location = new Point(608, 245);
            showAllFlights.Name = "showAllFlights";
            showAllFlights.Size = new Size(136, 41);
            showAllFlights.TabIndex = 28;
            showAllFlights.Text = "Все рейсы";
            showAllFlights.UseVisualStyleBackColor = true;
            // 
            // sortFieldSelect
            // 
            sortFieldSelect.FormattingEnabled = true;
            sortFieldSelect.Items.AddRange(new object[] { "Время отправления", "Время прибытия", "Статус", "Аэропрт отправления", "Аэропорт прибытия" });
            sortFieldSelect.Location = new Point(675, 353);
            sortFieldSelect.Name = "sortFieldSelect";
            sortFieldSelect.Size = new Size(136, 23);
            sortFieldSelect.TabIndex = 29;
            // 
            // sortDescBtn
            // 
            sortDescBtn.Location = new Point(644, 423);
            sortDescBtn.Name = "sortDescBtn";
            sortDescBtn.Size = new Size(136, 41);
            sortDescBtn.TabIndex = 30;
            sortDescBtn.Text = "По убыванию";
            sortDescBtn.UseVisualStyleBackColor = true;
            // 
            // sortAscBtn
            // 
            sortAscBtn.Location = new Point(758, 306);
            sortAscBtn.Name = "sortAscBtn";
            sortAscBtn.Size = new Size(136, 41);
            sortAscBtn.TabIndex = 31;
            sortAscBtn.Text = "По возрастанию";
            sortAscBtn.UseVisualStyleBackColor = true;
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(828, 406);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(76, 15);
            sortLabel.TabIndex = 32;
            sortLabel.Text = "Сортировка:";
            // 
            // sortFieldLabel
            // 
            sortFieldLabel.AutoSize = true;
            sortFieldLabel.Location = new Point(805, 492);
            sortFieldLabel.Name = "sortFieldLabel";
            sortFieldLabel.Size = new Size(98, 15);
            sortFieldLabel.TabIndex = 33;
            sortFieldLabel.Text = "Сортировать по:";
            // 
            // departureDateSelectCalendar
            // 
            departureDateSelectCalendar.Location = new Point(734, 201);
            departureDateSelectCalendar.MaxSelectionCount = 1;
            departureDateSelectCalendar.MinDate = new DateTime(2025, 1, 23, 0, 0, 0, 0);
            departureDateSelectCalendar.Name = "departureDateSelectCalendar";
            departureDateSelectCalendar.TabIndex = 34;
            // 
            // departureDateselectLabel
            // 
            departureDateselectLabel.AutoSize = true;
            departureDateselectLabel.Location = new Point(805, 170);
            departureDateselectLabel.Name = "departureDateselectLabel";
            departureDateselectLabel.Size = new Size(164, 15);
            departureDateselectLabel.TabIndex = 35;
            departureDateselectLabel.Text = "Выберите дату отправления:";
            // 
            // resetFiltersBtn
            // 
            resetFiltersBtn.Location = new Point(400, 289);
            resetFiltersBtn.Name = "resetFiltersBtn";
            resetFiltersBtn.Size = new Size(136, 41);
            resetFiltersBtn.TabIndex = 36;
            resetFiltersBtn.Text = "Сбросить фильтры";
            resetFiltersBtn.UseVisualStyleBackColor = true;
            // 
            // FlightListPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(resetFiltersBtn);
            Controls.Add(departureDateselectLabel);
            Controls.Add(departureDateSelectCalendar);
            Controls.Add(sortFieldLabel);
            Controls.Add(sortLabel);
            Controls.Add(sortAscBtn);
            Controls.Add(sortDescBtn);
            Controls.Add(sortFieldSelect);
            Controls.Add(showAllFlights);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(showMyFlightsBtn);
            Controls.Add(flightListDataGrid);
            Name = "FlightListPanel";
            Size = new Size(1167, 696);
            SizeChanged += FlightListPanel_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)flightListDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView flightListDataGrid;
        private Button showMyFlightsBtn;
        private Label searchLabel;
        private TextBox searchTextBox;
        private Button showAllFlights;
        private ComboBox sortFieldSelect;
        private Button sortDescBtn;
        private Button sortAscBtn;
        private Label sortLabel;
        private Label sortFieldLabel;
        private MonthCalendar departureDateSelectCalendar; // Календарь на выбор дня отправления
        private Label departureDateselectLabel;//Лейбл на выбор дня отправления
        private Button resetFiltersBtn;//Сброс фильтров
    }
}
