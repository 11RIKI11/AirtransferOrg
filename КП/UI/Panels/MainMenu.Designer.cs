namespace КП.UI.Panels
{
    partial class MainMenu
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
            showStaffBtn = new Button();
            showCrewBtn = new Button();
            airlinesBtn = new Button();
            swowMyAirlineBtn = new Button();
            showUsersBtn = new Button();
            logoutBtn = new Button();
            flightTimetableBtn = new Button();
            myBookingInfoBtn = new Button();
            SuspendLayout();
            // 
            // showMyCrewBtn
            // 
            showMyCrewBtn.Location = new Point(267, 93);
            showMyCrewBtn.Name = "showMyCrewBtn";
            showMyCrewBtn.Size = new Size(136, 41);
            showMyCrewBtn.TabIndex = 45;
            showMyCrewBtn.Text = "Мой экипаж";
            showMyCrewBtn.UseVisualStyleBackColor = true;
            showMyCrewBtn.Click += showMyCrewBtn_Click;
            // 
            // showStaffBtn
            // 
            showStaffBtn.Location = new Point(409, 46);
            showStaffBtn.Name = "showStaffBtn";
            showStaffBtn.Size = new Size(136, 41);
            showStaffBtn.TabIndex = 43;
            showStaffBtn.Text = "Персонал";
            showStaffBtn.UseVisualStyleBackColor = true;
            showStaffBtn.Click += showStaffBtn_Click;
            // 
            // showCrewBtn
            // 
            showCrewBtn.Location = new Point(267, 46);
            showCrewBtn.Name = "showCrewBtn";
            showCrewBtn.Size = new Size(136, 41);
            showCrewBtn.TabIndex = 42;
            showCrewBtn.Text = "Экипажи";
            showCrewBtn.UseVisualStyleBackColor = true;
            showCrewBtn.Click += showCrewBtn_Click;
            // 
            // airlinesBtn
            // 
            airlinesBtn.Location = new Point(125, 46);
            airlinesBtn.Name = "airlinesBtn";
            airlinesBtn.Size = new Size(136, 41);
            airlinesBtn.TabIndex = 41;
            airlinesBtn.Text = "Авиакомпании";
            airlinesBtn.UseVisualStyleBackColor = true;
            airlinesBtn.Click += airlinesBtn_Click;
            // 
            // swowMyAirlineBtn
            // 
            swowMyAirlineBtn.Location = new Point(551, 93);
            swowMyAirlineBtn.Name = "swowMyAirlineBtn";
            swowMyAirlineBtn.Size = new Size(136, 41);
            swowMyAirlineBtn.TabIndex = 40;
            swowMyAirlineBtn.Text = "Моя авиакомпания";
            swowMyAirlineBtn.UseVisualStyleBackColor = true;
            swowMyAirlineBtn.Click += swowMyAirlineBtn_Click;
            // 
            // showUsersBtn
            // 
            showUsersBtn.Location = new Point(551, 46);
            showUsersBtn.Name = "showUsersBtn";
            showUsersBtn.Size = new Size(136, 41);
            showUsersBtn.TabIndex = 39;
            showUsersBtn.Text = "Просмотреть пользователей";
            showUsersBtn.UseVisualStyleBackColor = true;
            showUsersBtn.Click += showUsersBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(551, 5);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(136, 41);
            logoutBtn.TabIndex = 37;
            logoutBtn.Text = "Выход";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // flightTimetableBtn
            // 
            flightTimetableBtn.Location = new Point(267, 5);
            flightTimetableBtn.Name = "flightTimetableBtn";
            flightTimetableBtn.Size = new Size(136, 41);
            flightTimetableBtn.TabIndex = 36;
            flightTimetableBtn.Text = "Расписание рейсов";
            flightTimetableBtn.UseVisualStyleBackColor = true;
            flightTimetableBtn.Click += flightTimetableBtn_Click;
            // 
            // myBookingInfoBtn
            // 
            myBookingInfoBtn.Location = new Point(409, 5);
            myBookingInfoBtn.Name = "myBookingInfoBtn";
            myBookingInfoBtn.Size = new Size(136, 41);
            myBookingInfoBtn.TabIndex = 35;
            myBookingInfoBtn.Text = "Мои билеты";
            myBookingInfoBtn.UseVisualStyleBackColor = true;
            myBookingInfoBtn.Click += myBookingInfoBtn_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(showMyCrewBtn);
            Controls.Add(showStaffBtn);
            Controls.Add(showCrewBtn);
            Controls.Add(airlinesBtn);
            Controls.Add(swowMyAirlineBtn);
            Controls.Add(showUsersBtn);
            Controls.Add(logoutBtn);
            Controls.Add(flightTimetableBtn);
            Controls.Add(myBookingInfoBtn);
            Name = "MainMenu";
            Size = new Size(690, 355);
            SizeChanged += MainMenu_SizeChanged;
            ResumeLayout(false);
        }


        #endregion

        private Button showMyCrewBtn;
        private Button showStaffBtn;
        private Button showCrewBtn;
        private Button airlinesBtn;
        private Button swowMyAirlineBtn;
        private Button showUsersBtn;
        private Button logoutBtn;
        private Button flightTimetableBtn;
        private Button myBookingInfoBtn;
    }
}
