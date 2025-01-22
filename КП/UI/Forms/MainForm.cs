using КП.Infrastructure;
using КП.Forms;

namespace КП
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Load += MainForm_Load;
            MessageDisplay.RegisterParentForm(this);
            PanelManager.RegistrationParentControl(this);

            //Переключение между панелями
            PanelManager.RegisterPanel(new Panel1());
            PanelManager.RegisterPanel(new Panel2());
            PanelManager.SwitchTo<Panel1>();


            //Форма для логов
            LogForm logForm = new LogForm();
            logForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Пример использования окон для сообщений
            MessageDisplay.ShowMessage("aaaaaaaa", Core.Enums.MessageType.Error);
            MessageDisplay.ShowMessage("bbbbbbbb", Core.Enums.MessageType.Success);
        }
    }
}
