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
            myBookingInfoBtn.Location = new Point(429, 21);
            myBookingInfoBtn.Margin = new Padding(3, 4, 3, 4);
            myBookingInfoBtn.Name = "myBookingInfoBtn";
            myBookingInfoBtn.Size = new Size(155, 55);
            myBookingInfoBtn.TabIndex = 0;
            myBookingInfoBtn.Text = "Мои билеты";
            myBookingInfoBtn.UseVisualStyleBackColor = true;
            myBookingInfoBtn.Click += myBookingInfoBtn_Click;
            // 
            // flightTimetableBtn
            // 
            flightTimetableBtn.Location = new Point(266, 21);
            flightTimetableBtn.Margin = new Padding(3, 4, 3, 4);
            flightTimetableBtn.Name = "flightTimetableBtn";
            flightTimetableBtn.Size = new Size(155, 55);
            flightTimetableBtn.TabIndex = 3;
            flightTimetableBtn.Text = "Расписание рейсов";
            flightTimetableBtn.UseVisualStyleBackColor = true;
            flightTimetableBtn.Click += flightTimetableBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(591, 21);
            logoutBtn.Margin = new Padding(3, 4, 3, 4);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(155, 55);
            logoutBtn.TabIndex = 4;
            logoutBtn.Text = "Выход";
            logoutBtn.UseVisualStyleBackColor = true;
            // 
            // profileBtn
            // 
            profileBtn.Location = new Point(104, 21);
            profileBtn.Margin = new Padding(3, 4, 3, 4);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(155, 55);
            profileBtn.TabIndex = 5;
            profileBtn.Text = "Профиль";
            profileBtn.UseVisualStyleBackColor = true;
            // 
            // showUsersBtn
            // 
            showUsersBtn.Location = new Point(591, 76);
            showUsersBtn.Margin = new Padding(3, 4, 3, 4);
            showUsersBtn.Name = "showUsersBtn";
            showUsersBtn.Size = new Size(155, 55);
            showUsersBtn.TabIndex = 6;
            showUsersBtn.Text = "Просмотреть пользователей";
            showUsersBtn.UseVisualStyleBackColor = true;
            // 
            // swowMyAirlineBtn
            // 
            swowMyAirlineBtn.Location = new Point(591, 139);
            swowMyAirlineBtn.Margin = new Padding(3, 4, 3, 4);
            swowMyAirlineBtn.Name = "swowMyAirlineBtn";
            swowMyAirlineBtn.Size = new Size(155, 55);
            swowMyAirlineBtn.TabIndex = 7;
            swowMyAirlineBtn.Text = "Моя авиакомпания";
            swowMyAirlineBtn.UseVisualStyleBackColor = true;
            // 
            // airlinesBtn
            // 
            airlinesBtn.Location = new Point(104, 76);
            airlinesBtn.Margin = new Padding(3, 4, 3, 4);
            airlinesBtn.Name = "airlinesBtn";
            airlinesBtn.Size = new Size(155, 55);
            airlinesBtn.TabIndex = 8;
            airlinesBtn.Text = "Авиакомпании";
            airlinesBtn.UseVisualStyleBackColor = true;
            // 
            // showCrewBtn
            // 
            showCrewBtn.Location = new Point(266, 76);
            showCrewBtn.Margin = new Padding(3, 4, 3, 4);
            showCrewBtn.Name = "showCrewBtn";
            showCrewBtn.Size = new Size(155, 55);
            showCrewBtn.TabIndex = 9;
            showCrewBtn.Text = "Экипажи";
            showCrewBtn.UseVisualStyleBackColor = true;
            // 
            // showStaffBtn
            // 
            showStaffBtn.Location = new Point(429, 76);
            showStaffBtn.Margin = new Padding(3, 4, 3, 4);
            showStaffBtn.Name = "showStaffBtn";
            showStaffBtn.Size = new Size(155, 55);
            showStaffBtn.TabIndex = 10;
            showStaffBtn.Text = "Персонал";
            showStaffBtn.UseVisualStyleBackColor = true;
            // 
            // createFlightBtn
            // 
            createFlightBtn.Location = new Point(429, 139);
            createFlightBtn.Margin = new Padding(3, 4, 3, 4);
            createFlightBtn.Name = "createFlightBtn";
            createFlightBtn.Size = new Size(155, 55);
            createFlightBtn.TabIndex = 11;
            createFlightBtn.Text = "Создать рейс";
            createFlightBtn.UseVisualStyleBackColor = true;
            // 
            // showMyCrewBtn
            // 
            showMyCrewBtn.Location = new Point(266, 139);
            showMyCrewBtn.Margin = new Padding(3, 4, 3, 4);
            showMyCrewBtn.Name = "showMyCrewBtn";
            showMyCrewBtn.Size = new Size(155, 55);
            showMyCrewBtn.TabIndex = 12;
            showMyCrewBtn.Text = "Мой экипаж";
            showMyCrewBtn.UseVisualStyleBackColor = true;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainPanel";
            Size = new Size(766, 490);
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
