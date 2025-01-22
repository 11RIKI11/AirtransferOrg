using System;
using System.Drawing;
using System.Windows.Forms;
using КП.Infrastructure;

namespace КП.Forms
{
    public partial class LogForm : Form
    {
        private RichTextBox logRichTextBox;

        public LogForm()
        {
            InitializeComponent();
            Load += LogForm_Load;
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            InitializeLogForm();
        }

        private void InitializeLogForm()
        {
            // Скрываем саму форму
            this.Hide();

            // Создаем и настраиваем RichTextBox
            logRichTextBox = new RichTextBox
            {
                Dock = DockStyle.Fill, // Растягиваем на всю форму
                Font = new Font("Consolas", 10),
                ReadOnly = true,
                BackColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.None
            };

            // Добавляем RichTextBox на экран
            Controls.Add(logRichTextBox);

            // Добавляем кнопку закрытия
            Button closeButton = new Button
            {
                Text = "Закрыть",
                Size = new Size(100, 40),
                Location = new Point(250, 760), // Положение кнопки закрытия
                BackColor = Color.FromArgb(60, 60, 60),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.Click += (s, args) => this.Close(); // Закрытие формы
            Controls.Add(closeButton);

            // Настроить лог
            Logger.SetLogDisplay(logRichTextBox);
            Logger.Info("Программа запущена.");
        }
    }
}
