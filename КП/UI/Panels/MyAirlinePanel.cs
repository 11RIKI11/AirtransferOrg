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

            var mainMenu = new MainMenu
            {
                Dock = DockStyle.Top  // Устанавливаем DockStyle.Top для фиксации в верхней части
            };

            this.Controls.Add(mainMenu);
        }

        private void MyAirlinePanel_SizeChanged(object sender, EventArgs e)
        {
            aircraftsListDataGrid.Location = new Point(this.Width / 2 - aircraftsListDataGrid.Width / 2, this.Height / 2 - aircraftsListDataGrid.Height / 2 - 80);
            airlineFlightsDataGrid.Location = new Point(aircraftsListDataGrid.Location.X, aircraftsListDataGrid.Location.Y + aircraftsListDataGrid.Height + 20);
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
        }

    }
}
