namespace КП.UI.Panels
{
    partial class ShowUsers
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
            usersListDataGrid = new DataGridView();
            searchTextBox = new TextBox();
            searchLabel = new Label();
            resetFiltersBtn = new Button();
            sortFieldLabel = new Label();
            sortLabel = new Label();
            sortDescBtn = new Button();
            sortFieldSelect = new ComboBox();
            sortAscBtn = new Button();
            roleLabel = new Label();
            roleSelectBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)usersListDataGrid).BeginInit();
            SuspendLayout();
            // 
            // showMyCrewBtn
            // 
            showMyCrewBtn.Location = new Point(589, 121);
            showMyCrewBtn.Margin = new Padding(3, 4, 3, 4);
            showMyCrewBtn.Name = "showMyCrewBtn";
            showMyCrewBtn.Size = new Size(155, 55);
            showMyCrewBtn.TabIndex = 23;
            showMyCrewBtn.Text = "Мой экипаж";
            showMyCrewBtn.UseVisualStyleBackColor = true;
            // 
            // createFlightBtn
            // 
            createFlightBtn.Location = new Point(751, 121);
            createFlightBtn.Margin = new Padding(3, 4, 3, 4);
            createFlightBtn.Name = "createFlightBtn";
            createFlightBtn.Size = new Size(155, 55);
            createFlightBtn.TabIndex = 22;
            createFlightBtn.Text = "Создать рейс";
            createFlightBtn.UseVisualStyleBackColor = true;
            // 
            // showStaffBtn
            // 
            showStaffBtn.Location = new Point(751, 59);
            showStaffBtn.Margin = new Padding(3, 4, 3, 4);
            showStaffBtn.Name = "showStaffBtn";
            showStaffBtn.Size = new Size(155, 55);
            showStaffBtn.TabIndex = 21;
            showStaffBtn.Text = "Персонал";
            showStaffBtn.UseVisualStyleBackColor = true;
            // 
            // showCrewBtn
            // 
            showCrewBtn.Location = new Point(589, 59);
            showCrewBtn.Margin = new Padding(3, 4, 3, 4);
            showCrewBtn.Name = "showCrewBtn";
            showCrewBtn.Size = new Size(155, 55);
            showCrewBtn.TabIndex = 20;
            showCrewBtn.Text = "Экипажи";
            showCrewBtn.UseVisualStyleBackColor = true;
            // 
            // airlinesBtn
            // 
            airlinesBtn.Location = new Point(426, 59);
            airlinesBtn.Margin = new Padding(3, 4, 3, 4);
            airlinesBtn.Name = "airlinesBtn";
            airlinesBtn.Size = new Size(155, 55);
            airlinesBtn.TabIndex = 19;
            airlinesBtn.Text = "Авиакомпании";
            airlinesBtn.UseVisualStyleBackColor = true;
            // 
            // swowMyAirlineBtn
            // 
            swowMyAirlineBtn.Location = new Point(913, 121);
            swowMyAirlineBtn.Margin = new Padding(3, 4, 3, 4);
            swowMyAirlineBtn.Name = "swowMyAirlineBtn";
            swowMyAirlineBtn.Size = new Size(155, 55);
            swowMyAirlineBtn.TabIndex = 18;
            swowMyAirlineBtn.Text = "Моя авиакомпания";
            swowMyAirlineBtn.UseVisualStyleBackColor = true;
            // 
            // showUsersBtn
            // 
            showUsersBtn.Location = new Point(913, 59);
            showUsersBtn.Margin = new Padding(3, 4, 3, 4);
            showUsersBtn.Name = "showUsersBtn";
            showUsersBtn.Size = new Size(155, 55);
            showUsersBtn.TabIndex = 17;
            showUsersBtn.Text = "Просмотреть пользователей";
            showUsersBtn.UseVisualStyleBackColor = true;
            // 
            // profileBtn
            // 
            profileBtn.Location = new Point(426, 4);
            profileBtn.Margin = new Padding(3, 4, 3, 4);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(155, 55);
            profileBtn.TabIndex = 16;
            profileBtn.Text = "Профиль";
            profileBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(913, 4);
            logoutBtn.Margin = new Padding(3, 4, 3, 4);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(155, 55);
            logoutBtn.TabIndex = 15;
            logoutBtn.Text = "Выход";
            logoutBtn.UseVisualStyleBackColor = true;
            // 
            // flightTimetableBtn
            // 
            flightTimetableBtn.Location = new Point(589, 4);
            flightTimetableBtn.Margin = new Padding(3, 4, 3, 4);
            flightTimetableBtn.Name = "flightTimetableBtn";
            flightTimetableBtn.Size = new Size(155, 55);
            flightTimetableBtn.TabIndex = 14;
            flightTimetableBtn.Text = "Расписание рейсов";
            flightTimetableBtn.UseVisualStyleBackColor = true;
            // 
            // myBookingInfoBtn
            // 
            myBookingInfoBtn.Location = new Point(751, 4);
            myBookingInfoBtn.Margin = new Padding(3, 4, 3, 4);
            myBookingInfoBtn.Name = "myBookingInfoBtn";
            myBookingInfoBtn.Size = new Size(155, 55);
            myBookingInfoBtn.TabIndex = 13;
            myBookingInfoBtn.Text = "Мои билеты";
            myBookingInfoBtn.UseVisualStyleBackColor = true;
            // 
            // usersListDataGrid
            // 
            usersListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersListDataGrid.Location = new Point(145, 105);
            usersListDataGrid.Margin = new Padding(3, 4, 3, 4);
            usersListDataGrid.Name = "usersListDataGrid";
            usersListDataGrid.RowHeadersWidth = 51;
            usersListDataGrid.Size = new Size(747, 497);
            usersListDataGrid.TabIndex = 25;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(814, 299);
            searchTextBox.Margin = new Padding(3, 4, 3, 4);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(155, 27);
            searchTextBox.TabIndex = 29;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(814, 268);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(59, 20);
            searchLabel.TabIndex = 28;
            searchLabel.Text = "Искать:";
            // 
            // resetFiltersBtn
            // 
            resetFiltersBtn.Location = new Point(248, 216);
            resetFiltersBtn.Margin = new Padding(3, 4, 3, 4);
            resetFiltersBtn.Name = "resetFiltersBtn";
            resetFiltersBtn.Size = new Size(155, 55);
            resetFiltersBtn.TabIndex = 41;
            resetFiltersBtn.Text = "Сбросить фильтры";
            resetFiltersBtn.UseVisualStyleBackColor = true;
            // 
            // sortFieldLabel
            // 
            sortFieldLabel.AutoSize = true;
            sortFieldLabel.Location = new Point(711, 487);
            sortFieldLabel.Name = "sortFieldLabel";
            sortFieldLabel.Size = new Size(124, 20);
            sortFieldLabel.TabIndex = 40;
            sortFieldLabel.Text = "Сортировать по:";
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(737, 372);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(95, 20);
            sortLabel.TabIndex = 39;
            sortLabel.Text = "Сортировка:";
            // 
            // sortDescBtn
            // 
            sortDescBtn.Location = new Point(527, 395);
            sortDescBtn.Margin = new Padding(3, 4, 3, 4);
            sortDescBtn.Name = "sortDescBtn";
            sortDescBtn.Size = new Size(155, 55);
            sortDescBtn.TabIndex = 38;
            sortDescBtn.Text = "По убыванию";
            sortDescBtn.UseVisualStyleBackColor = true;
            // 
            // sortFieldSelect
            // 
            sortFieldSelect.FormattingEnabled = true;
            sortFieldSelect.Items.AddRange(new object[] { "Имя", "Фамилия", "Электронная почта" });
            sortFieldSelect.Location = new Point(562, 301);
            sortFieldSelect.Margin = new Padding(3, 4, 3, 4);
            sortFieldSelect.Name = "sortFieldSelect";
            sortFieldSelect.Size = new Size(155, 28);
            sortFieldSelect.TabIndex = 37;
            // 
            // sortAscBtn
            // 
            sortAscBtn.Location = new Point(458, 335);
            sortAscBtn.Margin = new Padding(3, 4, 3, 4);
            sortAscBtn.Name = "sortAscBtn";
            sortAscBtn.Size = new Size(155, 55);
            sortAscBtn.TabIndex = 42;
            sortAscBtn.Text = "По возрастанию";
            sortAscBtn.UseVisualStyleBackColor = true;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(769, 204);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(45, 20);
            roleLabel.TabIndex = 43;
            roleLabel.Text = "Роль:";
            // 
            // roleSelectBox
            // 
            roleSelectBox.FormattingEnabled = true;
            roleSelectBox.Items.AddRange(new object[] { "Администратор", "Члены экипажа", "Персонал", "Пользователь", "Представитель авиакомпании" });
            roleSelectBox.Location = new Point(527, 229);
            roleSelectBox.Margin = new Padding(3, 4, 3, 4);
            roleSelectBox.Name = "roleSelectBox";
            roleSelectBox.Size = new Size(155, 28);
            roleSelectBox.TabIndex = 44;
            // 
            // ShowUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(roleSelectBox);
            Controls.Add(roleLabel);
            Controls.Add(sortAscBtn);
            Controls.Add(resetFiltersBtn);
            Controls.Add(sortFieldLabel);
            Controls.Add(sortLabel);
            Controls.Add(sortDescBtn);
            Controls.Add(sortFieldSelect);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(usersListDataGrid);
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
            Name = "ShowUsers";
            Size = new Size(1072, 724);
            SizeChanged += ShowUsers_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)usersListDataGrid).EndInit();
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
        private DataGridView usersListDataGrid;
        private TextBox searchTextBox;
        private Label searchLabel;
        private Button resetFiltersBtn;
        private Label sortFieldLabel;
        private Label sortLabel;
        private Button sortDescBtn;
        private ComboBox sortFieldSelect;
        private Button sortAscBtn;
        private Label roleLabel;
        private ComboBox roleSelectBox;
    }
}
