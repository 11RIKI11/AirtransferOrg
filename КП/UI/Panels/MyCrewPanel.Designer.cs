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
            myCrewListDataGrid = new DataGridView();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            sortLabel = new Label();
            sortFieldLabel = new Label();
            sortFieldSelect = new ComboBox();
            sortDescBtn = new Button();
            sortAscBtn = new Button();
            resetFiltersBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)myCrewListDataGrid).BeginInit();
            SuspendLayout();
            // 
            // myCrewListDataGrid
            // 
            myCrewListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myCrewListDataGrid.Location = new Point(246, 105);
            myCrewListDataGrid.Name = "myCrewListDataGrid";
            myCrewListDataGrid.Size = new Size(462, 380);
            myCrewListDataGrid.TabIndex = 25;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(714, 156);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(48, 15);
            searchLabel.TabIndex = 27;
            searchLabel.Text = "Искать:";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(678, 218);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(136, 23);
            searchTextBox.TabIndex = 28;
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(724, 266);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(76, 15);
            sortLabel.TabIndex = 33;
            sortLabel.Text = "Сортировка:";
            // 
            // sortFieldLabel
            // 
            sortFieldLabel.AutoSize = true;
            sortFieldLabel.Location = new Point(714, 307);
            sortFieldLabel.Name = "sortFieldLabel";
            sortFieldLabel.Size = new Size(98, 15);
            sortFieldLabel.TabIndex = 34;
            sortFieldLabel.Text = "Сортировать по:";
            // 
            // sortFieldSelect
            // 
            sortFieldSelect.FormattingEnabled = true;
            sortFieldSelect.Items.AddRange(new object[] { "Имени", "Фамилии", "Должности" });
            sortFieldSelect.Location = new Point(714, 357);
            sortFieldSelect.Name = "sortFieldSelect";
            sortFieldSelect.Size = new Size(136, 23);
            sortFieldSelect.TabIndex = 35;
            // 
            // sortDescBtn
            // 
            sortDescBtn.Location = new Point(714, 413);
            sortDescBtn.Name = "sortDescBtn";
            sortDescBtn.Size = new Size(136, 41);
            sortDescBtn.TabIndex = 36;
            sortDescBtn.Text = "По убыванию";
            sortDescBtn.UseVisualStyleBackColor = true;
            // 
            // sortAscBtn
            // 
            sortAscBtn.Location = new Point(714, 460);
            sortAscBtn.Name = "sortAscBtn";
            sortAscBtn.Size = new Size(136, 41);
            sortAscBtn.TabIndex = 37;
            sortAscBtn.Text = "По возрастанию";
            sortAscBtn.UseVisualStyleBackColor = true;
            // 
            // resetFiltersBtn
            // 
            resetFiltersBtn.Location = new Point(419, 253);
            resetFiltersBtn.Name = "resetFiltersBtn";
            resetFiltersBtn.Size = new Size(136, 41);
            resetFiltersBtn.TabIndex = 38;
            resetFiltersBtn.Text = "Сбросить фильтры";
            resetFiltersBtn.UseVisualStyleBackColor = true;
            // 
            // MyCrewPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(resetFiltersBtn);
            Controls.Add(sortAscBtn);
            Controls.Add(sortDescBtn);
            Controls.Add(sortFieldSelect);
            Controls.Add(sortFieldLabel);
            Controls.Add(sortLabel);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(myCrewListDataGrid);
            Name = "MyCrewPanel";
            Size = new Size(974, 547);
            SizeChanged += MyCrewPanel_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)myCrewListDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView myCrewListDataGrid;
        private Label searchLabel;
        private TextBox searchTextBox;
        private Label sortLabel;
        private Label sortFieldLabel;
        private ComboBox sortFieldSelect;
        private Button sortDescBtn;
        private Button sortAscBtn;
        private Button resetFiltersBtn;
    }
}
