using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using КП.Infrastructure;

namespace КП.UI.Panels
{
    public partial class MainPanel : UserControl
    {
        public MainPanel()
        {
            InitializeComponent();
            ParentChanged += MainPanel_ParentChanged;
        }

        private void MainPanel_ParentChanged(object? sender, EventArgs e)
        {
            var mainMenu = new MainMenu
            {
                Dock = DockStyle.Top  // Устанавливаем DockStyle.Top для фиксации в верхней части
            };

            this.Controls.Add(mainMenu);
            mainMenu.BringToFront();  // Выводим панель на передний план
        }

        private void MainPanel_SizeChanged(object sender, EventArgs e)
        {
            
        }
        private void flightTimetableBtn_Click(object sender, EventArgs e)
        {
            PanelManager.SwitchTo<FlightListPanel>();
        }

        private void myBookingInfoBtn_Click(object sender, EventArgs e)
        {
            PanelManager.SwitchTo<MyTickets>();
        }

        private void showUsersBtn_Click(object sender, EventArgs e)
        {
            PanelManager.SwitchTo<ShowUsers>();
        }
    }
}
