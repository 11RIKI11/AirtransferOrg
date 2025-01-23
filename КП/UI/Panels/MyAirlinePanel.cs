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
    public partial class MyAirlinePanel : UserControl
    {
        public MyAirlinePanel()
        {
            InitializeComponent();

            ParentChanged += CreateMainMenu;
        }

        private void CreateMainMenu(object? sender, EventArgs e)
        {
            var mainMenu = new MainMenu
            {
                Dock = DockStyle.Top  // Устанавливаем DockStyle.Top для фиксации в верхней части
            };

            this.Controls.Add(mainMenu);
            mainMenu.BringToFront();  // Выводим панель на передний план
        }


        private void MyAirlinePanel_SizeChanged(object sender, EventArgs e)
        {
            aircraftsListDataGrid.Location = new Point(this.Width / 2 - aircraftsListDataGrid.Width / 2, this.Height / 2 - aircraftsListDataGrid.Height / 2 - 80);
            airlineFlightsDataGrid.Location = new Point(aircraftsListDataGrid.Location.X, aircraftsListDataGrid.Location.Y + aircraftsListDataGrid.Height + 40);
            searchLabel.Location = new Point(aircraftsListDataGrid.Location.X + aircraftsListDataGrid.Width + 40, aircraftsListDataGrid.Location.Y + searchLabel.Height);
            searchTextBox.Location = new Point(searchLabel.Location.X, searchLabel.Location.Y + searchTextBox.Height);
            resetFiltersBtn.Location = new Point(searchTextBox.Location.X, searchTextBox.Location.Y + resetFiltersBtn.Height);
            sortLabel.Location = new Point(resetFiltersBtn.Location.X, resetFiltersBtn.Location.Y + resetFiltersBtn.Height + 10);
            sortFieldLabel.Location = new Point(sortLabel.Location.X, sortLabel.Location.Y + sortLabel.Height);
            sortFieldSelect.Location = new Point(sortFieldLabel.Location.X, sortFieldLabel.Location.Y + sortFieldLabel.Height);
            sortAscBtn.Location = new Point(sortFieldSelect.Location.X, sortFieldSelect.Location.Y + sortFieldSelect.Height + 10);
            sortDescBtn.Location = new Point(sortAscBtn.Location.X, sortAscBtn.Location.Y + sortAscBtn.Height + 10);
            sortFieldSelect.SelectedIndex = 0;
            aircraftListLabel.Location = new Point(20, aircraftsListDataGrid.Location.Y - aircraftListLabel.Height);
            addressLabel.Location = new Point(20, aircraftListLabel.Location.Y - addressLabel.Height);
            airlineLabel.Location = new Point(20, addressLabel.Location.Y - airlineLabel.Height);

            airlineFlightsLabel.Location = new Point(20, airlineFlightsDataGrid.Location.Y - airlineFlightsLabel.Height);

            searchFlightsLabel.Location = new Point(airlineFlightsDataGrid.Location.X + airlineFlightsDataGrid.Width + 40, airlineFlightsDataGrid.Location.Y + searchFlightsLabel.Height);
            searchFlightTextBox.Location = new Point(searchFlightsLabel.Location.X, searchFlightsLabel.Location.Y + searchFlightsLabel.Height + 20);
            flightsResetFiltersBtn.Location = new Point(searchFlightTextBox.Location.X, searchFlightTextBox.Location.Y + searchFlightTextBox.Height);
            sortFlightLabel.Location = new Point(flightsResetFiltersBtn.Location.X, flightsResetFiltersBtn.Location.Y + flightsResetFiltersBtn.Height);
            flightSortFieldLabel.Location = new Point(sortFlightLabel.Location.X, sortFlightLabel.Location.Y + flightSortFieldLabel.Height);
            sortFlightsComboBox.Location = new Point(flightSortFieldLabel.Location.X, flightSortFieldLabel.Location.Y + sortFlightsComboBox.Height);
            flightSortAscBtn.Location = new Point(sortFlightsComboBox.Location.X, sortFlightsComboBox.Location.Y + flightSortAscBtn.Height);
            flightsSortDesc.Location = new Point(flightSortAscBtn.Location.X, flightSortAscBtn.Location.Y + flightsSortDesc.Height);
        }

    }
}
