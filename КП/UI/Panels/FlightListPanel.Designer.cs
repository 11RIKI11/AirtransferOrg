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
            showMyCrewBtn = new Button();
            createFlightBtn = new Button();
            showStaffBtn = new Button();
            showCrewBtn = new Button();
            airlinesBtn = new Button();
            swowMyAirlineBtn = new Button();
            showUsersBtn = new Button();
            profileBtn = new Button();
            logoutBtn = new Button();
            flightTimetableBtn = new Button();
            myBookingInfoBtn = new Button();
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
            // showMyCrewBtn
            // 
            showMyCrewBtn.Location = new Point(251, 95);
            showMyCrewBtn.Name = "showMyCrewBtn";
            showMyCrewBtn.Size = new Size(136, 41);
            showMyCrewBtn.TabIndex = 23;
            showMyCrewBtn.Text = "Мой экипаж";
            showMyCrewBtn.UseVisualStyleBackColor = true;
            // 
            // createFlightBtn
            // 
            createFlightBtn.Location = new Point(393, 95);
            createFlightBtn.Name = "createFlightBtn";
            createFlightBtn.Size = new Size(136, 41);
            createFlightBtn.TabIndex = 22;
            createFlightBtn.Text = "Создать рейс";
            createFlightBtn.UseVisualStyleBackColor = true;
            // 
            // showStaffBtn
            // 
            showStaffBtn.Location = new Point(393, 48);
            showStaffBtn.Name = "showStaffBtn";
            showStaffBtn.Size = new Size(136, 41);
            showStaffBtn.TabIndex = 21;
            showStaffBtn.Text = "Персонал";
            showStaffBtn.UseVisualStyleBackColor = true;
            // 
            // showCrewBtn
            // 
            showCrewBtn.Location = new Point(251, 48);
            showCrewBtn.Name = "showCrewBtn";
            showCrewBtn.Size = new Size(136, 41);
            showCrewBtn.TabIndex = 20;
            showCrewBtn.Text = "Экипажи";
            showCrewBtn.UseVisualStyleBackColor = true;
            // 
            // airlinesBtn
            // 
            airlinesBtn.Location = new Point(109, 48);
            airlinesBtn.Name = "airlinesBtn";
            airlinesBtn.Size = new Size(136, 41);
            airlinesBtn.TabIndex = 19;
            airlinesBtn.Text = "Авиакомпании";
            airlinesBtn.UseVisualStyleBackColor = true;
            // 
            // swowMyAirlineBtn
            // 
            swowMyAirlineBtn.Location = new Point(535, 95);
            swowMyAirlineBtn.Name = "swowMyAirlineBtn";
            swowMyAirlineBtn.Size = new Size(136, 41);
            swowMyAirlineBtn.TabIndex = 18;
            swowMyAirlineBtn.Text = "Моя авиакомпания";
            swowMyAirlineBtn.UseVisualStyleBackColor = true;
            // 
            // showUsersBtn
            // 
            showUsersBtn.Location = new Point(535, 48);
            showUsersBtn.Name = "showUsersBtn";
            showUsersBtn.Size = new Size(136, 41);
            showUsersBtn.TabIndex = 17;
            showUsersBtn.Text = "Просмотреть пользователей";
            showUsersBtn.UseVisualStyleBackColor = true;
            // 
            // profileBtn
            // 
            profileBtn.Location = new Point(109, 7);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(136, 41);
            profileBtn.TabIndex = 16;
            profileBtn.Text = "Профиль";
            profileBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(535, 7);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(136, 41);
            logoutBtn.TabIndex = 15;
            logoutBtn.Text = "Выход";
            logoutBtn.UseVisualStyleBackColor = true;
            // 
            // flightTimetableBtn
            // 
            flightTimetableBtn.Location = new Point(251, 7);
            flightTimetableBtn.Name = "flightTimetableBtn";
            flightTimetableBtn.Size = new Size(136, 41);
            flightTimetableBtn.TabIndex = 14;
            flightTimetableBtn.Text = "Расписание рейсов";
            flightTimetableBtn.UseVisualStyleBackColor = true;
            // 
            // myBookingInfoBtn
            // 
            myBookingInfoBtn.Location = new Point(393, 7);
            myBookingInfoBtn.Name = "myBookingInfoBtn";
            myBookingInfoBtn.Size = new Size(136, 41);
            myBookingInfoBtn.TabIndex = 13;
            myBookingInfoBtn.Text = "Мои билеты";
            myBookingInfoBtn.UseVisualStyleBackColor = true;
            // 
            // flightListDataGrid
            // 
            flightListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            flightListDataGrid.Location = new Point(130, 48);
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
            Controls.Add(showMyCrewBtn);
            Controls.Add(createFlightBtn);
            Controls.Add(showStaffBtn);
            Controls.Add(showCrewBtn);
            Controls.Add(airlinesBtn);
            Controls.Add(swowMyAirlineBtn);
            Controls.Add(showUsersBtn);
            Controls.Add(profileBtn);
            Controls.Add(logoutBtn);
            Controls.Add(flightTimetableBtn);
            Controls.Add(myBookingInfoBtn);
            Name = "FlightListPanel";
            Size = new Size(1167, 696);
            SizeChanged += FlightListPanel_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)flightListDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button showMyCrewBtn;
        private Button createFlightBtn;
        private Button showStaffBtn;
        private Button showCrewBtn;
        private Button airlinesBtn;
        private Button swowMyAirlineBtn;
        private Button showUsersBtn;
        private Button profileBtn;
        private Button logoutBtn;
        private Button flightTimetableBtn;
        private Button myBookingInfoBtn;
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
