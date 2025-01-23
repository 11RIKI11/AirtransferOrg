namespace КП.UI.Panels
{
    partial class ShowStaffPanel
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
            staffListDataGrid = new DataGridView();
            sortAscBtn = new Button();
            resetFiltersBtn = new Button();
            sortFieldLabel = new Label();
            sortLabel = new Label();
            sortDescBtn = new Button();
            sortFieldSelect = new ComboBox();
            searchTextBox = new TextBox();
            searchLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)staffListDataGrid).BeginInit();
            SuspendLayout();
            // 
            // staffListDataGrid
            // 
            staffListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffListDataGrid.Location = new Point(207, 129);
            staffListDataGrid.Name = "staffListDataGrid";
            staffListDataGrid.RowHeadersWidth = 51;
            staffListDataGrid.Size = new Size(654, 373);
            staffListDataGrid.TabIndex = 26;
            // 
            // sortAscBtn
            // 
            sortAscBtn.Location = new Point(403, 295);
            sortAscBtn.Name = "sortAscBtn";
            sortAscBtn.Size = new Size(136, 41);
            sortAscBtn.TabIndex = 50;
            sortAscBtn.Text = "По возрастанию";
            sortAscBtn.UseVisualStyleBackColor = true;
            // 
            // resetFiltersBtn
            // 
            resetFiltersBtn.Location = new Point(219, 206);
            resetFiltersBtn.Name = "resetFiltersBtn";
            resetFiltersBtn.Size = new Size(136, 41);
            resetFiltersBtn.TabIndex = 49;
            resetFiltersBtn.Text = "Сбросить фильтры";
            resetFiltersBtn.UseVisualStyleBackColor = true;
            // 
            // sortFieldLabel
            // 
            sortFieldLabel.AutoSize = true;
            sortFieldLabel.Location = new Point(624, 409);
            sortFieldLabel.Name = "sortFieldLabel";
            sortFieldLabel.Size = new Size(98, 15);
            sortFieldLabel.TabIndex = 48;
            sortFieldLabel.Text = "Сортировать по:";
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(647, 323);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(76, 15);
            sortLabel.TabIndex = 47;
            sortLabel.Text = "Сортировка:";
            // 
            // sortDescBtn
            // 
            sortDescBtn.Location = new Point(463, 340);
            sortDescBtn.Name = "sortDescBtn";
            sortDescBtn.Size = new Size(136, 41);
            sortDescBtn.TabIndex = 46;
            sortDescBtn.Text = "По убыванию";
            sortDescBtn.UseVisualStyleBackColor = true;
            // 
            // sortFieldSelect
            // 
            sortFieldSelect.FormattingEnabled = true;
            sortFieldSelect.Items.AddRange(new object[] { "Имя", "Фамилия", "Электронная почта", "Должность" });
            sortFieldSelect.Location = new Point(494, 270);
            sortFieldSelect.Name = "sortFieldSelect";
            sortFieldSelect.Size = new Size(136, 23);
            sortFieldSelect.TabIndex = 45;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(714, 268);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(136, 23);
            searchTextBox.TabIndex = 44;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(714, 245);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(48, 15);
            searchLabel.TabIndex = 43;
            searchLabel.Text = "Искать:";
            // 
            // ShowStaffPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(sortAscBtn);
            Controls.Add(resetFiltersBtn);
            Controls.Add(sortFieldLabel);
            Controls.Add(sortLabel);
            Controls.Add(sortDescBtn);
            Controls.Add(sortFieldSelect);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(staffListDataGrid);
            Name = "ShowStaffPanel";
            Size = new Size(1069, 630);
            SizeChanged += ShowStaffPanel_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)staffListDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private DataGridView staffListDataGrid;
        private Button sortAscBtn;
        private Button resetFiltersBtn;
        private Label sortFieldLabel;
        private Label sortLabel;
        private Button sortDescBtn;
        private ComboBox sortFieldSelect;
        private TextBox searchTextBox;
        private Label searchLabel;
    }
}
