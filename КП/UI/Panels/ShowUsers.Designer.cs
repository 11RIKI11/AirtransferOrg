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
            // usersListDataGrid
            // 
            usersListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersListDataGrid.Location = new Point(79, 138);
            usersListDataGrid.Name = "usersListDataGrid";
            usersListDataGrid.RowHeadersWidth = 51;
            usersListDataGrid.Size = new Size(654, 373);
            usersListDataGrid.TabIndex = 25;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(712, 224);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(136, 23);
            searchTextBox.TabIndex = 29;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(712, 201);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(48, 15);
            searchLabel.TabIndex = 28;
            searchLabel.Text = "Искать:";
            // 
            // resetFiltersBtn
            // 
            resetFiltersBtn.Location = new Point(217, 162);
            resetFiltersBtn.Name = "resetFiltersBtn";
            resetFiltersBtn.Size = new Size(136, 41);
            resetFiltersBtn.TabIndex = 41;
            resetFiltersBtn.Text = "Сбросить фильтры";
            resetFiltersBtn.UseVisualStyleBackColor = true;
            // 
            // sortFieldLabel
            // 
            sortFieldLabel.AutoSize = true;
            sortFieldLabel.Location = new Point(622, 365);
            sortFieldLabel.Name = "sortFieldLabel";
            sortFieldLabel.Size = new Size(98, 15);
            sortFieldLabel.TabIndex = 40;
            sortFieldLabel.Text = "Сортировать по:";
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(645, 279);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(76, 15);
            sortLabel.TabIndex = 39;
            sortLabel.Text = "Сортировка:";
            // 
            // sortDescBtn
            // 
            sortDescBtn.Location = new Point(461, 296);
            sortDescBtn.Name = "sortDescBtn";
            sortDescBtn.Size = new Size(136, 41);
            sortDescBtn.TabIndex = 38;
            sortDescBtn.Text = "По убыванию";
            sortDescBtn.UseVisualStyleBackColor = true;
            // 
            // sortFieldSelect
            // 
            sortFieldSelect.FormattingEnabled = true;
            sortFieldSelect.Items.AddRange(new object[] { "Имя", "Фамилия", "Электронная почта" });
            sortFieldSelect.Location = new Point(492, 226);
            sortFieldSelect.Name = "sortFieldSelect";
            sortFieldSelect.Size = new Size(136, 23);
            sortFieldSelect.TabIndex = 37;
            // 
            // sortAscBtn
            // 
            sortAscBtn.Location = new Point(401, 251);
            sortAscBtn.Name = "sortAscBtn";
            sortAscBtn.Size = new Size(136, 41);
            sortAscBtn.TabIndex = 42;
            sortAscBtn.Text = "По возрастанию";
            sortAscBtn.UseVisualStyleBackColor = true;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.Location = new Point(673, 153);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(37, 15);
            roleLabel.TabIndex = 43;
            roleLabel.Text = "Роль:";
            // 
            // roleSelectBox
            // 
            roleSelectBox.FormattingEnabled = true;
            roleSelectBox.Items.AddRange(new object[] { "Администратор", "Члены экипажа", "Персонал", "Пользователь", "Представитель авиакомпании" });
            roleSelectBox.Location = new Point(461, 172);
            roleSelectBox.Name = "roleSelectBox";
            roleSelectBox.Size = new Size(136, 23);
            roleSelectBox.TabIndex = 44;
            // 
            // ShowUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "ShowUsers";
            Size = new Size(938, 543);
            SizeChanged += ShowUsers_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)usersListDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
