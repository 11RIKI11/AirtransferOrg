using КП.Infrastructure;
using КП.Forms;

namespace КП
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            MessageDisplay.RegisterParentForm(this);
            PanelManager.RegistrationParentControl(this);

            Shown += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Переключение между панелями
            PanelManager.RegisterPanel(new LoginPanel());
            PanelManager.RegisterPanel(new RegisterPanel());

            PanelManager.SwitchTo<LoginPanel>();


            //Форма для логов
            LogForm logForm = new LogForm();
            logForm.Show();
        }
    }
}
