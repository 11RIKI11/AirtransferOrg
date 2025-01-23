namespace КП.UI.Panels
{
    partial class ShowCrewsListPanel
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
            crewListDataGrid = new DataGridView();
            sortAscBtn = new Button();
            sortFieldLabel = new Label();
            sortLabel = new Label();
            sortDescBtn = new Button();
            searchTextBox = new TextBox();
            searchLabel = new Label();
            sortFieldSelect = new ComboBox();
            resetFiltersBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)crewListDataGrid).BeginInit();
            SuspendLayout();
            // 
            // crewListDataGrid
            // 
            crewListDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            crewListDataGrid.Location = new Point(151, 26);
            crewListDataGrid.Name = "crewListDataGrid";
            crewListDataGrid.Size = new Size(462, 380);
            crewListDataGrid.TabIndex = 26;
            // 
            // sortAscBtn
            // 
            sortAscBtn.Location = new Point(159, 177);
            sortAscBtn.Name = "sortAscBtn";
            sortAscBtn.Size = new Size(136, 41);
            sortAscBtn.TabIndex = 49;
            sortAscBtn.Text = "По возрастанию";
            sortAscBtn.UseVisualStyleBackColor = true;
            // 
            // sortFieldLabel
            // 
            sortFieldLabel.AutoSize = true;
            sortFieldLabel.Location = new Point(380, 291);
            sortFieldLabel.Name = "sortFieldLabel";
            sortFieldLabel.Size = new Size(98, 15);
            sortFieldLabel.TabIndex = 48;
            sortFieldLabel.Text = "Сортировать по:";
            // 
            // sortLabel
            // 
            sortLabel.AutoSize = true;
            sortLabel.Location = new Point(403, 205);
            sortLabel.Name = "sortLabel";
            sortLabel.Size = new Size(76, 15);
            sortLabel.TabIndex = 47;
            sortLabel.Text = "Сортировка:";
            // 
            // sortDescBtn
            // 
            sortDescBtn.Location = new Point(219, 222);
            sortDescBtn.Name = "sortDescBtn";
            sortDescBtn.Size = new Size(136, 41);
            sortDescBtn.TabIndex = 46;
            sortDescBtn.Text = "По убыванию";
            sortDescBtn.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(470, 150);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(136, 23);
            searchTextBox.TabIndex = 44;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Location = new Point(470, 127);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(48, 15);
            searchLabel.TabIndex = 43;
            searchLabel.Text = "Искать:";
            // 
            // sortFieldSelect
            // 
            sortFieldSelect.FormattingEnabled = true;
            sortFieldSelect.Items.AddRange(new object[] { "Название", "Количество членов экипажа" });
            sortFieldSelect.Location = new Point(250, 152);
            sortFieldSelect.Name = "sortFieldSelect";
            sortFieldSelect.Size = new Size(136, 23);
            sortFieldSelect.TabIndex = 45;
            // 
            // resetFiltersBtn
            // 
            resetFiltersBtn.Location = new Point(477, 249);
            resetFiltersBtn.Name = "resetFiltersBtn";
            resetFiltersBtn.Size = new Size(136, 41);
            resetFiltersBtn.TabIndex = 50;
            resetFiltersBtn.Text = "Сбросить фильтры";
            resetFiltersBtn.UseVisualStyleBackColor = true;
            // 
            // ShowCrewsListPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(resetFiltersBtn);
            Controls.Add(sortAscBtn);
            Controls.Add(sortFieldLabel);
            Controls.Add(sortLabel);
            Controls.Add(sortDescBtn);
            Controls.Add(sortFieldSelect);
            Controls.Add(searchTextBox);
            Controls.Add(searchLabel);
            Controls.Add(crewListDataGrid);
            Name = "ShowCrewsListPanel";
            Size = new Size(764, 432);
            SizeChanged += ShowCrewsListPanel_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)crewListDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private DataGridView crewListDataGrid;
        private Button sortAscBtn;
        private Label sortFieldLabel;
        private Label sortLabel;
        private Button sortDescBtn;
        private TextBox searchTextBox;
        private Label searchLabel;
        private ComboBox sortFieldSelect;
        private Button resetFiltersBtn;
    }
}
