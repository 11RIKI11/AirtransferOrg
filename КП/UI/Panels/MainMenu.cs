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
    public partial class MainMenu : UserControl
    {
        public MainMenu()
        {
            InitializeComponent();

            if (UserSession.Role != "crew_member")
            {
                showMyCrewBtn.Hide();
            }
        }
        private void MainMenu_SizeChanged(object sender, EventArgs e)
        {
            this.Height = showMyCrewBtn.Location.Y + showMyCrewBtn.Height + 10;
            this.BringToFront();
            logoutBtn.Location = new Point(this.Width - logoutBtn.Width - 20, 20);
            flightTimetableBtn.Location = new Point(logoutBtn.Location.X - flightTimetableBtn.Width - 20, 20);
            myBookingInfoBtn.Location = new Point(flightTimetableBtn.Location.X - myBookingInfoBtn.Width - 20, 20);
            profileBtn.Location = new Point(myBookingInfoBtn.Location.X - profileBtn.Width - 20, 20);
            showUsersBtn.Location = new Point(profileBtn.Location.X - profileBtn.Width - 20, 20);
            showStaffBtn.Location = new Point(showUsersBtn.Location.X - showStaffBtn.Width - 20, 20);
            showCrewBtn.Location = new Point(showStaffBtn.Location.X - showCrewBtn.Width - 20, 20);
            airlinesBtn.Location = new Point(showCrewBtn.Location.X - airlinesBtn.Width - 20, 20);
            swowMyAirlineBtn.Location = new Point(airlinesBtn.Location.X - swowMyAirlineBtn.Width - 20, 20);
            createFlightBtn.Location = new Point(swowMyAirlineBtn.Location.X - createFlightBtn.Width - 20, 20);
            showMyCrewBtn.Location = new Point(createFlightBtn.Location.X - showMyCrewBtn.Width - 20, 20);
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            UserSession.Logout();
            PanelManager.SwitchTo<LoginPanel>();
        }

        private void showMyCrewBtn_Click(object sender, EventArgs e)
        {
            PanelManager.SwitchTo<MyCrewPanel>();
        }

        private void showStaffBtn_Click(object sender, EventArgs e)
        {
            PanelManager.SwitchTo<ShowStaffPanel>();
        }

        private void showCrewBtn_Click(object sender, EventArgs e)
        {
            PanelManager.SwitchTo<ShowCrewsListPanel>();
        }

        private void airlinesBtn_Click(object sender, EventArgs e)
        {
            PanelManager.SwitchTo<ShowAirlinesPanel>();
        }

        private void createFlightBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void swowMyAirlineBtn_Click(object sender, EventArgs e)
        {

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
