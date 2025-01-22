using System.Text.RegularExpressions;
using КП.Infrastructure;

public class RegisterPanel : UserControl
{
    private TextBox firstNameTextBox;
    private TextBox lastNameTextBox;
    private TextBox phoneTextBox;
    private TextBox emailTextBox;
    private TextBox passwordTextBox;
    private ComboBox roleComboBox;
    private Button registerButton;
    private Button backButton;
    private Panel containerPanel;

    public RegisterPanel()
    {
        this.Dock = DockStyle.Fill;
        this.BackColor = Color.LightSkyBlue;
        SizeChanged += RegisterPanel_SizeChanged;
    }

    public void RegisterPanel_SizeChanged(object sender, EventArgs e)
    {
        SizeChanged -= RegisterPanel_SizeChanged;

        containerPanel = new Panel()
        {
            BackColor = Color.LightSkyBlue,
            Size = new Size(400, 700),
            Location = new Point((Width - 400) / 2, (Height - 700) / 2)
        };

        var titleLabel = new Label()
        {
            Text = "Регистрация",
            Font = new Font("Arial", 22, FontStyle.Bold),
            Location = new Point((containerPanel.Width - 300) / 2, 20),
            AutoSize = true
        };

        firstNameTextBox = CreateTextBox("Имя", 100, out Label firstNameLabel);
        lastNameTextBox = CreateTextBox("Фамилия", 160, out Label lastNameLabel);
        phoneTextBox = CreateTextBox("Телефон", 220, out Label phoneLabel);
        emailTextBox = CreateTextBox("Email", 280, out Label emailLabel);
        passwordTextBox = CreateTextBox("Пароль", 340, out Label passwordLabel);
        passwordTextBox.PasswordChar = '*';

        var roleLabel = new Label()
        {
            Text = "Роль",
            Font = new Font("Arial", 14),
            Location = new Point((containerPanel.Width - 300) / 2, 380),
            AutoSize = true
        };

        roleComboBox = new ComboBox()
        {
            Width = 300,
            Font = new Font("Arial", 14),
            DropDownStyle = ComboBoxStyle.DropDownList,
            Location = new Point((containerPanel.Width - 300) / 2, 410)
        };
        roleComboBox.Items.AddRange(new string[] { "Пользователь", "Администратор" });

        // Кнопка "Зарегистрироваться"
        registerButton = new Button()
        {
            Text = "Зарегистрироваться",
            Width = 200,
            Height = 50,
            BackColor = Color.DarkOliveGreen,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Arial", 12, FontStyle.Bold),
            Cursor = Cursors.Hand,
            Location = new Point((containerPanel.Width - 200) / 2, 480)
        };
        registerButton.Click += RegisterButton_Click;

        // Кнопка "Назад"
        backButton = new Button()
        {
            Text = "Назад",
            Width = 200,
            Height = 50,
            BackColor = Color.Gray,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Arial", 12, FontStyle.Bold),
            Cursor = Cursors.Hand,
            Location = new Point((containerPanel.Width - 200) / 2, 550)
        };
        backButton.Click += BackButton_Click;

        // Добавление элементов в контейнер
        containerPanel.Controls.Add(titleLabel);
        containerPanel.Controls.Add(firstNameLabel);
        containerPanel.Controls.Add(firstNameTextBox);
        containerPanel.Controls.Add(lastNameLabel);
        containerPanel.Controls.Add(lastNameTextBox);
        containerPanel.Controls.Add(phoneLabel);
        containerPanel.Controls.Add(phoneTextBox);
        containerPanel.Controls.Add(emailLabel);
        containerPanel.Controls.Add(emailTextBox);
        containerPanel.Controls.Add(passwordLabel);
        containerPanel.Controls.Add(passwordTextBox);
        containerPanel.Controls.Add(roleLabel);
        containerPanel.Controls.Add(roleComboBox);
        containerPanel.Controls.Add(registerButton);
        containerPanel.Controls.Add(backButton);

        this.Controls.Add(containerPanel);
    }

    private TextBox CreateTextBox(string placeholder, int yPosition, out Label label)
    {
        label = new Label()
        {
            Text = placeholder,
            Font = new Font("Arial", 14),
            Location = new Point((containerPanel.Width - 300) / 2, yPosition - 25),
            AutoSize = true
        };

        var textBox = new TextBox()
        {
            Width = 300,
            Font = new Font("Arial", 14),
            BorderStyle = BorderStyle.FixedSingle,
            Location = new Point((containerPanel.Width - 300) / 2, yPosition)
        };

        return textBox;
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
        // Выполнение валидации
        var validationMessage = ValidateInputs();
        if (!string.IsNullOrEmpty(validationMessage))
        {
            MessageDisplay.ShowMessage(validationMessage, КП.Core.Enums.MessageType.Error);
            return;
        }

        //TODO запрос в бд
        MessageDisplay.ShowMessage("Вы успешно зарегистрированы", КП.Core.Enums.MessageType.Success);
        PanelManager.SwitchTo<LoginPanel>();
    }

    private string ValidateInputs()
    {

        if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || !Regex.IsMatch(firstNameTextBox.Text, @"^[А-ЯЁ][а-яё]+$"))
        {
            return "Имя должно быть на русском языке с заглавной буквы, без пробелов.";
        }

        if (string.IsNullOrWhiteSpace(lastNameTextBox.Text) || !Regex.IsMatch(lastNameTextBox.Text, @"^[А-ЯЁ][а-яё]+$"))
        {
            return "Фамилия должна быть на русском языке с заглавной буквы, без пробелов.";
        }

        if (string.IsNullOrWhiteSpace(phoneTextBox.Text) || !Regex.IsMatch(phoneTextBox.Text, @"^\+7\s\(\d{3}\)\s\d{3}-\d{2}-\d{2}$"))
        {
            return "Неверный формат телефона. Пример: +7 (123) 456-78-90";
        }

        if (string.IsNullOrWhiteSpace(emailTextBox.Text) || !Regex.IsMatch(emailTextBox.Text, @"^[\w-]+(\.[\w-]+)*@[\w-]+\.[a-z]{2,6}$"))
        {
            return "Неверный формат email.";
        }

        if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || passwordTextBox.Text.Length < 6 || !Regex.IsMatch(passwordTextBox.Text, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d).+$"))
        {
            return "Пароль должен быть не менее 6 символов и содержать хотя бы одну заглавную букву, цифру и букву.";
        }

        if (roleComboBox.SelectedItem == null)
        {
            return "Выберите роль.";
        }

        return string.Empty;
    }

    private void BackButton_Click(object sender, EventArgs e)
    {
        PanelManager.SwitchBack();
    }
}
