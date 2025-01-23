using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КП.UI.Panels
{
    public partial class ShowUsers : UserControl
    {
        public ShowUsers()
        {
            InitializeComponent();
        }
        private void ShowUsers_SizeChanged(object sender, EventArgs e)
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
            flightListDataGrid.Location = new Point(this.Width / 2 - flightListDataGrid.Width / 2, this.Height / 2 - flightListDataGrid.Height / 2);
            roleLabel.Location = new Point(flightListDataGrid.Location.X + flightListDataGrid.Width + 40, flightListDataGrid.Location.Y + roleLabel.Height);
            roleSelectBox.Location = new Point(roleLabel.Location.X, roleLabel.Location.Y + roleLabel.Height);
            searchLabel.Location = new Point(roleSelectBox.Location.X, roleSelectBox.Location.Y + roleSelectBox.Height + 10);
            searchTextBox.Location = new Point(searchLabel.Location.X, searchLabel.Location.Y + searchLabel.Height);
            resetFiltersBtn.Location = new Point(searchTextBox.Location.X, searchTextBox.Location.Y + searchTextBox.Height + 10);
            sortLabel.Location = new Point(resetFiltersBtn.Location.X, resetFiltersBtn.Location.Y + resetFiltersBtn.Height + 10);
            sortFieldLabel.Location = new Point(sortLabel.Location.X, sortLabel.Location.Y + sortLabel.Height);
            sortFieldSelect.Location = new Point(sortFieldLabel.Location.X, sortFieldLabel.Location.Y + sortFieldLabel.Height);
            sortAscBtn.Location = new Point(sortFieldSelect.Location.X, sortFieldSelect.Location.Y + sortFieldSelect.Height + 10);
            sortDescBtn.Location = new Point(sortAscBtn.Location.X, sortAscBtn.Location.Y + sortAscBtn.Height + 10);
            sortFieldSelect.SelectedIndex = 0;
            roleSelectBox.SelectedIndex = 3;
        }
    }
}
