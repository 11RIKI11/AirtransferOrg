using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using КП.Infrastructure;
using КП.UI.Panels;

namespace КП.UI.Panels;

public partial class LoginPanel : UserControl
{
    private TextBox emailTextBox;
    private TextBox passwordTextBox;
    private Button loginButton;
    private Button registerButton;
    private Label emailLabel;
    private Label passwordLabel;
    private Label titleLabel;
    private Panel containerPanel;

    public LoginPanel()
    {
        this.Dock = DockStyle.Fill;
        this.BackColor = Color.LightSkyBlue;
        SizeChanged += LoginPanel_SizeChanged;
    }

    public void LoginPanel_SizeChanged(object sender, EventArgs e)
    {
        SizeChanged -= LoginPanel_SizeChanged;//Отпишись

        containerPanel = new Panel()
        {
            BackColor = Color.LightSkyBlue,
            Size = new Size(400, 500),
            Location = new Point((Width - 400) / 2, (Height - 500) / 2)
        };

        titleLabel = new Label()
        {
            Text = "Авторизация",
            AutoSize = true,
            Font = new Font("Arial", 22, FontStyle.Bold),
            ForeColor = Color.DarkSlateGray,
            Location = new Point((containerPanel.Width - 300) / 2, 20),
            Anchor = AnchorStyles.None
        };

        emailLabel = new Label()
        {
            Text = "Электронная почта:",
            AutoSize = true,
            Font = new Font("Arial", 14, FontStyle.Bold),
            ForeColor = Color.Navy,
            Location = new Point((containerPanel.Width - 300) / 2, 80)
        };

        emailTextBox = new TextBox()
        {
            Width = 300,
            Font = new Font("Arial", 14),
            BorderStyle = BorderStyle.FixedSingle,
            Location = new Point((containerPanel.Width - 300) / 2, 110)
        };

        passwordLabel = new Label()
        {
            Text = "Пароль:",
            AutoSize = true,
            Font = new Font("Arial", 14, FontStyle.Bold),
            ForeColor = Color.Navy,
            Location = new Point((containerPanel.Width - 300) / 2, 160)
        };

        passwordTextBox = new TextBox()
        {
            Width = 300,
            Font = new Font("Arial", 14),
            PasswordChar = '*',
            BorderStyle = BorderStyle.FixedSingle,
            Location = new Point((containerPanel.Width - 300) / 2, 190)
        };

        loginButton = new Button()
        {
            Text = "Войти",
            Width = 150,
            Height = 50,
            BackColor = Color.MediumSlateBlue,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Arial", 12, FontStyle.Bold),
            Cursor = Cursors.Hand,
            Location = new Point((containerPanel.Width - 150) / 2 - 90, 270)
        };
        loginButton.Click += LoginButton_Click;

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
            Location = new Point((containerPanel.Width - 200) / 2 + 90, 270)
        };
        registerButton.Click += RegisterButton_Click;

        containerPanel.Controls.Add(titleLabel);
        containerPanel.Controls.Add(emailLabel);
        containerPanel.Controls.Add(emailTextBox);
        containerPanel.Controls.Add(passwordLabel);
        containerPanel.Controls.Add(passwordTextBox);
        containerPanel.Controls.Add(loginButton);
        containerPanel.Controls.Add(registerButton);

        this.Controls.Add(containerPanel);
    }

    private void LoginButton_Click(object sender, EventArgs e)
    {
        string email = emailTextBox.Text;
        string password = passwordTextBox.Text;


        email = "crew1@example.com";
        password = "crewmember1password";

        string validationMessage = ValidateLoginFields(email, password);
        if (!string.IsNullOrEmpty(validationMessage))
        {
            MessageDisplay.ShowMessage(validationMessage, КП.Core.Enums.MessageType.Error);
            return;
        }

        var context = DbContextFactory.CreateContext();
        var user = context.Users
            .Include(u => u.Role)
            .FirstOrDefault(user => user.Email == email);
        
        if (user is null)
        {
            MessageDisplay.ShowMessage("Пользователь с таким email не найден", КП.Core.Enums.MessageType.Error);
            return;
        }

        if (user.Password != password)
        {
            MessageDisplay.ShowMessage("Неверный пароль", КП.Core.Enums.MessageType.Error);
            return;
        }
        UserSession.Login(user.Id, user.Role.Name);
        MessageDisplay.ShowMessage("Вы успешно вошли в аккаунт", КП.Core.Enums.MessageType.Success);
        PanelManager.SwitchTo<MainPanel>();
    }
    private string ValidateLoginFields(string email, string password)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return "Введите email.";
        }

        if (!Regex.IsMatch(email, @"^[\w-]+(\.[\w-]+)*@[\w-]+\.[a-z]{2,6}$"))
        {
            return "Неверный формат email.";
        }

        if (string.IsNullOrWhiteSpace(password))
        {
            return "Введите пароль.";
        }

        return string.Empty;
    }

    private void RegisterButton_Click(object sender, EventArgs e)
    {
        PanelManager.SwitchTo<RegisterPanel>();
    }
}
