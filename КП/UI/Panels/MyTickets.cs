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
    public partial class MyTickets : UserControl
    {
        public MyTickets()
        {
            InitializeComponent();
        }
        private void MyTickets_SizeChanged(object sender, EventArgs e)
        {
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
            myTicketsListDataGrid.Location = new Point(this.Width / 2 - myTicketsListDataGrid.Width / 2, this.Height / 2 - myTicketsListDataGrid.Height / 2);
            searchLabel.Location = new Point(myTicketsListDataGrid.Location.X + myTicketsListDataGrid.Width + 40, myTicketsListDataGrid.Location.Y + resetFiltersBtn.Height - searchTextBox.Height);
            searchTextBox.Location = new Point(searchLabel.Location.X, searchLabel.Location.Y + searchTextBox.Height);
            resetFiltersBtn.Location = new Point(searchTextBox.Location.X, searchTextBox.Location.Y + resetFiltersBtn.Height);

            sortLabel.Location = new Point(resetFiltersBtn.Location.X, resetFiltersBtn.Location.Y + resetFiltersBtn.Height + 10);
            sortFieldLabel.Location = new Point(sortLabel.Location.X, sortLabel.Location.Y + sortLabel.Height);
            sortFieldSelect.Location = new Point(sortFieldLabel.Location.X, sortFieldLabel.Location.Y + sortFieldLabel.Height);
            sortAscBtn.Location = new Point(sortFieldSelect.Location.X, sortFieldSelect.Location.Y + sortFieldSelect.Height + 10);
            sortDescBtn.Location = new Point(sortAscBtn.Location.X, sortAscBtn.Location.Y + sortAscBtn.Height + 10);
            sortFieldSelect.SelectedIndex = 0;
            departureDateselectLabel.Location = new Point(searchLabel.Location.X + searchTextBox.Width + 10, searchLabel.Location.Y);
            departureDateSelectCalendar.Location = new Point(searchTextBox.Location.X + searchTextBox.Width + 10, searchTextBox.Location.Y);
        }

        private void flightTimetableBtn_Click(object sender, EventArgs e)
        {
            PanelManager.SwitchTo<FlightListPanel>();
        }
    }
}
