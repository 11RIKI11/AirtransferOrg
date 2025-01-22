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
            flightListDataGrid.Location = new Point(94, 54);
            flightListDataGrid.Name = "flightListDataGrid";
            flightListDataGrid.Size = new Size(508, 499);
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
            // FlightListPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
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
            Size = new Size(937, 618);
            SizeChanged += FlightListPanel_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)flightListDataGrid).EndInit();
            ResumeLayout(false);
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
    }
}
