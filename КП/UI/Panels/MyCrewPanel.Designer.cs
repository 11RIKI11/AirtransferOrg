namespace КП.UI.Panels
{
    partial class MyCrewPanel
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
            SuspendLayout();
            // 
            // showMyCrewBtn
            // 
            showMyCrewBtn.Location = new Point(550, 91);
            showMyCrewBtn.Name = "showMyCrewBtn";
            showMyCrewBtn.Size = new Size(136, 41);
            showMyCrewBtn.TabIndex = 34;
            showMyCrewBtn.Text = "Мой экипаж";
            showMyCrewBtn.UseVisualStyleBackColor = true;
            // 
            // createFlightBtn
            // 
            createFlightBtn.Location = new Point(692, 91);
            createFlightBtn.Name = "createFlightBtn";
            createFlightBtn.Size = new Size(136, 41);
            createFlightBtn.TabIndex = 33;
            createFlightBtn.Text = "Создать рейс";
            createFlightBtn.UseVisualStyleBackColor = true;
            // 
            // showStaffBtn
            // 
            showStaffBtn.Location = new Point(692, 44);
            showStaffBtn.Name = "showStaffBtn";
            showStaffBtn.Size = new Size(136, 41);
            showStaffBtn.TabIndex = 32;
            showStaffBtn.Text = "Персонал";
            showStaffBtn.UseVisualStyleBackColor = true;
            // 
            // showCrewBtn
            // 
            showCrewBtn.Location = new Point(550, 44);
            showCrewBtn.Name = "showCrewBtn";
            showCrewBtn.Size = new Size(136, 41);
            showCrewBtn.TabIndex = 31;
            showCrewBtn.Text = "Экипажи";
            showCrewBtn.UseVisualStyleBackColor = true;
            // 
            // airlinesBtn
            // 
            airlinesBtn.Location = new Point(408, 44);
            airlinesBtn.Name = "airlinesBtn";
            airlinesBtn.Size = new Size(136, 41);
            airlinesBtn.TabIndex = 30;
            airlinesBtn.Text = "Авиакомпании";
            airlinesBtn.UseVisualStyleBackColor = true;
            // 
            // swowMyAirlineBtn
            // 
            swowMyAirlineBtn.Location = new Point(834, 91);
            swowMyAirlineBtn.Name = "swowMyAirlineBtn";
            swowMyAirlineBtn.Size = new Size(136, 41);
            swowMyAirlineBtn.TabIndex = 29;
            swowMyAirlineBtn.Text = "Моя авиакомпания";
            swowMyAirlineBtn.UseVisualStyleBackColor = true;
            // 
            // showUsersBtn
            // 
            showUsersBtn.Location = new Point(834, 44);
            showUsersBtn.Name = "showUsersBtn";
            showUsersBtn.Size = new Size(136, 41);
            showUsersBtn.TabIndex = 28;
            showUsersBtn.Text = "Просмотреть пользователей";
            showUsersBtn.UseVisualStyleBackColor = true;
            // 
            // profileBtn
            // 
            profileBtn.Location = new Point(408, 3);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(136, 41);
            profileBtn.TabIndex = 27;
            profileBtn.Text = "Профиль";
            profileBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(834, 3);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(136, 41);
            logoutBtn.TabIndex = 26;
            logoutBtn.Text = "Выход";
            logoutBtn.UseVisualStyleBackColor = true;
            // 
            // flightTimetableBtn
            // 
            flightTimetableBtn.Location = new Point(550, 3);
            flightTimetableBtn.Name = "flightTimetableBtn";
            flightTimetableBtn.Size = new Size(136, 41);
            flightTimetableBtn.TabIndex = 25;
            flightTimetableBtn.Text = "Расписание рейсов";
            flightTimetableBtn.UseVisualStyleBackColor = true;
            // 
            // myBookingInfoBtn
            // 
            myBookingInfoBtn.Location = new Point(692, 3);
            myBookingInfoBtn.Name = "myBookingInfoBtn";
            myBookingInfoBtn.Size = new Size(136, 41);
            myBookingInfoBtn.TabIndex = 24;
            myBookingInfoBtn.Text = "Мои билеты";
            myBookingInfoBtn.UseVisualStyleBackColor = true;
            // 
            // MyCrewPanel
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
            Name = "MyCrewPanel";
            Size = new Size(974, 547);
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
    }
}
