namespace КП.UI.Panels
{
    partial class MyTickets
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
            departureDateselectLabel = new Label();
            departureDateSelectCalendar = new MonthCalendar();
            sortFieldLabel = new Label();
            sortLabel = new Label();
            sortAscBtn = new Button();
            sortDescBtn = new Button();
            sortFieldSelect = new ComboBox();
            searchTextBox = new TextBox();
            searchLabel = new Label();
            myTicketsListDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)myTicketsListDataGrid).BeginInit();
            SuspendLayout();
            // 
            // resetFiltersBtn
            // 
            resetFiltersBtn.Location = new Point(429, 350);
            resetFiltersBtn.Name = "resetFiltersBtn";
            resetFiltersBtn.Size = new Size(136, 41);
            resetFiltersBtn.TabIndex = 52;
            resetFiltersBtn.Text = "Сбросить фильтры";
            resetFiltersBtn.UseVisualStyleBackColor = true;
            // 
            // departureDateselectLabel
            // 
            departureDateselectLabel.AutoSize = true;
            departureDateselectLabel.Location = new Point(834, 231);
            departureDateselectLabel.Name = "departureDateselectLabel";
            departureDateselectLabel.Size = new Size(164, 15);
            departureDateselectLabel.TabIndex = 51;
            departureDateselectLabel.Text = "Выберите дату отправления:";
            // 
            // departureDateSelectCalendar
            // 
            departureDateSelectCalendar.Location = new Point(763, 262);
            departureDateSelectCalendar.MaxSelectionCount = 1;
            departureDateSelectCalendar.MinDate = new DateTime(2025, 1, 23, 0, 0, 0, 0);
            departureDateSelectCalendar.Name = "departureDateSelectCalendar";
            departureDateSelectCalendar.TabIndex = 50;
            // 
            // sortFieldLabel
            // 
            sortFieldLabel.AutoSize = true;
            sortFieldLabel.Location = new Point(834, 553);
            sortFieldLabel.Name = "sortFieldLabel";
            sortFieldLabel.Size = new Size(98, 15);
            sortFieldLabel.TabIndex = 49;
            sortFieldLabel.Text = "Сортировать по:";
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(857, 467);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(76, 15);
            sortLabel.TabIndex = 48;
            sortLabel.Text = "Сортировка:";
            // 
            // sortAscBtn
            // 
            sortAscBtn.Location = new Point(787, 367);
            sortAscBtn.Name = "sortAscBtn";
            sortAscBtn.Size = new Size(136, 41);
            sortAscBtn.TabIndex = 47;
            sortAscBtn.Text = "По возрастанию";
            sortAscBtn.UseVisualStyleBackColor = true;
            // 
            // sortDescBtn
            // 
            sortDescBtn.Location = new Point(673, 484);
            sortDescBtn.Name = "sortDescBtn";
            sortDescBtn.Size = new Size(136, 41);
            sortDescBtn.TabIndex = 46;
            sortDescBtn.Text = "По убыванию";
            sortDescBtn.UseVisualStyleBackColor = true;
            // 
            // sortFieldSelect
            // 
            sortFieldSelect.AutoCompleteCustomSource.AddRange(new string[] { "Дата отправления", "Номер места", "Номер рейса", "Имя пассажира", "Фамилия пассажира", "Статус" });
            sortFieldSelect.FormattingEnabled = true;
            sortFieldSelect.Items.AddRange(new object[] { "Время отправления", "Время прибытия", "Статус", "Аэропрт отправления", "Аэропорт прибытия" });
            sortFieldSelect.Location = new Point(704, 414);
            sortFieldSelect.Name = "sortFieldSelect";
            sortFieldSelect.Size = new Size(136, 23);
            sortFieldSelect.TabIndex = 45;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(754, 205);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(136, 23);
            searchTextBox.TabIndex = 43;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(754, 182);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(48, 15);
            searchLabel.TabIndex = 42;
            searchLabel.Text = "Искать:";
            // 
            // myTicketsListDataGrid
            // 
            myTicketsListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myTicketsListDataGrid.Location = new Point(230, 157);
            myTicketsListDataGrid.Name = "myTicketsListDataGrid";
            myTicketsListDataGrid.Size = new Size(938, 561);
            myTicketsListDataGrid.TabIndex = 40;
            // 
            // MyTickets
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
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(myTicketsListDataGrid);
            Name = "MyTickets";
            Size = new Size(1129, 670);
            SizeChanged += MyTickets_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)myTicketsListDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button resetFiltersBtn;
        private Label departureDateselectLabel;
        private MonthCalendar departureDateSelectCalendar;
        private Label sortFieldLabel;
        private Label sortLabel;
        private Button sortAscBtn;
        private Button sortDescBtn;
        private ComboBox sortFieldSelect;
        private TextBox searchTextBox;
        private Label searchLabel;
        private DataGridView myTicketsListDataGrid;
    }
}
