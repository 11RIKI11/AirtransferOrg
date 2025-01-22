namespace КП.UI.Panels
{
    partial class MainPanel
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
            myBookingInfoBtn = new Button();
            flightTimetableBtn = new Button();
            logoutBtn = new Button();
            profileBtn = new Button();
            showUsersBtn = new Button();
            swowMyAirlineBtn = new Button();
            airlinesBtn = new Button();
            showCrewBtn = new Button();
            showStaffBtn = new Button();
            createFlightBtn = new Button();
            showMyCrewBtn = new Button();
            SuspendLayout();
            // 
            // myBookingInfoBtn
            // 
            myBookingInfoBtn.Location = new Point(375, 16);
            myBookingInfoBtn.Name = "myBookingInfoBtn";
            myBookingInfoBtn.Size = new Size(136, 41);
            myBookingInfoBtn.TabIndex = 0;
            myBookingInfoBtn.Text = "Мои билеты";
            myBookingInfoBtn.UseVisualStyleBackColor = true;
            myBookingInfoBtn.Click += myBookingInfoBtn_Click;
            // 
            // flightTimetableBtn
            // 
            flightTimetableBtn.Location = new Point(233, 16);
            flightTimetableBtn.Name = "flightTimetableBtn";
            flightTimetableBtn.Size = new Size(136, 41);
            flightTimetableBtn.TabIndex = 3;
            flightTimetableBtn.Text = "Расписание рейсов";
            flightTimetableBtn.UseVisualStyleBackColor = true;
            flightTimetableBtn.Click += flightTimetableBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(517, 16);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(136, 41);
            logoutBtn.TabIndex = 4;
            logoutBtn.Text = "Выход";
            logoutBtn.UseVisualStyleBackColor = true;
            // 
            // profileBtn
            // 
            profileBtn.Location = new Point(91, 16);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(136, 41);
            profileBtn.TabIndex = 5;
            profileBtn.Text = "Профиль";
            profileBtn.UseVisualStyleBackColor = true;
            // 
            // showUsersBtn
            // 
            showUsersBtn.Location = new Point(517, 57);
            showUsersBtn.Name = "showUsersBtn";
            showUsersBtn.Size = new Size(136, 41);
            showUsersBtn.TabIndex = 6;
            showUsersBtn.Text = "Просмотреть пользователей";
            showUsersBtn.UseVisualStyleBackColor = true;
            // 
            // swowMyAirlineBtn
            // 
            swowMyAirlineBtn.Location = new Point(517, 104);
            swowMyAirlineBtn.Name = "swowMyAirlineBtn";
            swowMyAirlineBtn.Size = new Size(136, 41);
            swowMyAirlineBtn.TabIndex = 7;
            swowMyAirlineBtn.Text = "Моя авиакомпания";
            swowMyAirlineBtn.UseVisualStyleBackColor = true;
            // 
            // airlinesBtn
            // 
            airlinesBtn.Location = new Point(91, 57);
            airlinesBtn.Name = "airlinesBtn";
            airlinesBtn.Size = new Size(136, 41);
            airlinesBtn.TabIndex = 8;
            airlinesBtn.Text = "Авиакомпании";
            airlinesBtn.UseVisualStyleBackColor = true;
            // 
            // showCrewBtn
            // 
            showCrewBtn.Location = new Point(233, 57);
            showCrewBtn.Name = "showCrewBtn";
            showCrewBtn.Size = new Size(136, 41);
            showCrewBtn.TabIndex = 9;
            showCrewBtn.Text = "Экипажи";
            showCrewBtn.UseVisualStyleBackColor = true;
            // 
            // showStaffBtn
            // 
            showStaffBtn.Location = new Point(375, 57);
            showStaffBtn.Name = "showStaffBtn";
            showStaffBtn.Size = new Size(136, 41);
            showStaffBtn.TabIndex = 10;
            showStaffBtn.Text = "Персонал";
            showStaffBtn.UseVisualStyleBackColor = true;
            // 
            // createFlightBtn
            // 
            createFlightBtn.Location = new Point(375, 104);
            createFlightBtn.Name = "createFlightBtn";
            createFlightBtn.Size = new Size(136, 41);
            createFlightBtn.TabIndex = 11;
            createFlightBtn.Text = "Создать рейс";
            createFlightBtn.UseVisualStyleBackColor = true;
            // 
            // showMyCrewBtn
            // 
            showMyCrewBtn.Location = new Point(233, 104);
            showMyCrewBtn.Name = "showMyCrewBtn";
            showMyCrewBtn.Size = new Size(136, 41);
            showMyCrewBtn.TabIndex = 12;
            showMyCrewBtn.Text = "Мой экипаж";
            showMyCrewBtn.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
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
            Name = "MainPanel";
            Size = new Size(670, 401);
            SizeChanged += MainUserPanel_SizeChanged;
            ResumeLayout(false);
        }

        #endregion

        private Button myBookingInfoBtn;
        private Button flightTimetableBtn;
        private Button logoutBtn;
        private Button profileBtn;
        private Button showUsersBtn;
        private Button swowMyAirlineBtn;
        private Button airlinesBtn;
        private Button showCrewBtn;
        private Button showStaffBtn;
        private Button createFlightBtn;
        private Button showMyCrewBtn;
    }
}
