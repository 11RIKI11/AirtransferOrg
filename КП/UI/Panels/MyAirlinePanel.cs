using Microsoft.EntityFrameworkCore;
using System.Data;
using КП.Core.Entities;
using КП.Infrastructure;

namespace КП.UI.Panels
{
    public partial class MyAirlinePanel : UserControl
    {
        private int aircraftsPageSize = 50;
        private int aircraftsCurrentPage = 0;
        private bool aircraftsSortAsc = true;
        private string aircraftsSearchText = string.Empty;

        private int flightsPageSize = 50;
        private int flightsCurrentPage = 0;
        private bool flightsSortAsc = true;
        private string flightsSearchText = string.Empty;

        public MyAirlinePanel()
        {
            InitializeComponent();
            ParentChanged += CreateMainMenu;
            ParentChanged += MyAirlinePanel_ParentChanged;

            searchTextBox.TextChanged += (s, e) => { aircraftsSearchText = searchTextBox.Text; ShowAircrafts(null, EventArgs.Empty); };
            searchFlightTextBox.TextChanged += (s, e) => { flightsSearchText = searchFlightTextBox.Text; ShowFlights(null, EventArgs.Empty); };
        }

        private void MyAirlinePanel_ParentChanged(object? sender, EventArgs e)
        {
            ShowAircrafts(null, EventArgs.Empty);
            ShowFlights(null, EventArgs.Empty);
            var context = DbContextFactory.CreateContext();
            var a = context.Airlines.OrderBy(a => a.Id).First();
            airlineLabel.Text += " " + a.Name;
            addressLabel.Text += " " + a.Country + " " + a.City + " " + a.Street + " " + a.BuildingNumb;
        }

        private void CreateMainMenu(object? sender, EventArgs e)
        {
            ParentChanged -= CreateMainMenu;
            var mainMenu = new MainMenu
            {
                Dock = DockStyle.Top
            };
            this.Controls.Add(mainMenu);
            mainMenu.BringToFront();
        }

        public async void ShowAircrafts(object sender, EventArgs e)
        {
            var aircrafts = await GetAircrafts();

            aircraftsListDataGrid.Columns.Clear();
            aircraftsListDataGrid.Columns.Add("RegistrationNumber", "Регистрационный номер");
            aircraftsListDataGrid.Columns.Add("Model", "Модель");

            aircraftsListDataGrid.Rows.Clear();

            foreach (var aircraft in aircrafts)
            {
                var rowIndex = aircraftsListDataGrid.Rows.Add(
                    aircraft.RegistationNumber,
                    aircraft.Model.ModelName
                );

                aircraftsListDataGrid.Rows[rowIndex].Tag = aircraft.Id;
            }
        }

        private async Task<List<Aircraft>> GetAircrafts()
        {
            var context = DbContextFactory.CreateContext();
            var query = context.Aircraft.Include(a => a.Model).AsQueryable();

            if (!string.IsNullOrEmpty(aircraftsSearchText))
            {
                query = query.Where(a => a.RegistationNumber.ToString().Contains(aircraftsSearchText) || a.Model.ModelName.Contains(aircraftsSearchText));
            }

            query = aircraftsSortAsc ? query.OrderBy(a => a.RegistationNumber) : query.OrderByDescending(a => a.RegistationNumber);
            query = query.Skip(aircraftsPageSize * aircraftsCurrentPage).Take(aircraftsPageSize);

            return await query.ToListAsync();
        }

        private void ClearAircraftFilters(object sender, EventArgs e)
        {
            aircraftsSortAsc = true;
            aircraftsCurrentPage = 0;
            aircraftsSearchText = string.Empty;
            ShowAircrafts(null, EventArgs.Empty);
        }

        public async void ShowFlights(object sender, EventArgs e)
        {
            var flights = await GetFlights();

            airlineFlightsDataGrid.Columns.Clear();
            airlineFlightsDataGrid.Columns.Add("FlightNumber", "Номер рейса");
            airlineFlightsDataGrid.Columns.Add("DepartureTime", "Дата отправления");
            airlineFlightsDataGrid.Columns.Add("ArrivalTime", "Дата прибытия");
            airlineFlightsDataGrid.Columns.Add("DepartureAirport", "Аэропорт отправления");
            airlineFlightsDataGrid.Columns.Add("ArrivalAirport", "Аэропорт прибытия");
            airlineFlightsDataGrid.Columns.Add("AircraftModel", "Модель самолета");
            airlineFlightsDataGrid.Columns.Add("Status", "Статус");

            airlineFlightsDataGrid.Rows.Clear();

            foreach (var flight in flights)
            {
                var rowIndex = airlineFlightsDataGrid.Rows.Add(
                    flight.Id,
                    flight.DepartureTime.ToDateTimeUnspecified().ToString("yyyy-MM-dd HH:mm"),
                    flight.ArrivalTime.Value.ToDateTimeUnspecified().ToString("yyyy-MM-dd HH:mm"),
                    flight.DepartureAirport.Name,
                    flight.ArrivalAirport.Name,
                    flight.Aircraft.Model.ModelName,
                    flight.Status.Name
                );

                airlineFlightsDataGrid.Rows[rowIndex].Tag = flight.Id;
            }
        }

        private async Task<List<Flight>> GetFlights()
        {
            var context = DbContextFactory.CreateContext();
            var query = context.Flights
                .Include(f => f.Airline)
                .Include(f => f.DepartureAirport)
                .Include(f => f.ArrivalAirport)
                .Include(f => f.Aircraft)
                .ThenInclude(a => a.Model)
                .Include(f => f.Status)
                .AsQueryable();

            if (!string.IsNullOrEmpty(flightsSearchText))
            {
                query = query
                    .Where(f => f.Id.ToString().Contains(flightsSearchText)
                        || f.DepartureAirport.Name.Contains(flightsSearchText)
                        || f.ArrivalAirport.Name.Contains(flightsSearchText));
            }

            query = flightsSortAsc ? query.OrderBy(f => f.Id.ToString()) : query.OrderByDescending(f => f.Id.ToString());
            query = query.Skip(flightsPageSize * flightsCurrentPage).Take(flightsPageSize);

            return await query.ToListAsync();
        }

        private void ClearFlightFilters(object sender, EventArgs e)
        {
            flightsSortAsc = true;
            flightsCurrentPage = 0;
            flightsSearchText = string.Empty;
            ShowFlights(null, EventArgs.Empty);
        }


        private void MyAirlinePanel_SizeChanged(object sender, EventArgs e)
        {
            aircraftsListDataGrid.Location = new Point(this.Width / 2 - aircraftsListDataGrid.Width - aircraftsListDataGrid.Width / 4, this.Height / 2 - aircraftsListDataGrid.Height / 2 - 80);
           
            searchLabel.Location = new Point(aircraftsListDataGrid.Location.X + aircraftsListDataGrid.Width + 40, aircraftsListDataGrid.Location.Y + searchLabel.Height);
            searchTextBox.Location = new Point(searchLabel.Location.X, searchLabel.Location.Y + searchTextBox.Height);
           
            aircraftListLabel.Location = new Point(20, aircraftsListDataGrid.Location.Y - aircraftListLabel.Height);
            addressLabel.Location = new Point(20, aircraftListLabel.Location.Y - addressLabel.Height);
            airlineLabel.Location = new Point(20, addressLabel.Location.Y - airlineLabel.Height);


            searchFlightsLabel.Location = new Point(airlineFlightsDataGrid.Location.X + airlineFlightsDataGrid.Width + 40, airlineFlightsDataGrid.Location.Y + searchFlightsLabel.Height);
            searchFlightTextBox.Location = new Point(searchFlightsLabel.Location.X, searchFlightsLabel.Location.Y + searchFlightTextBox.Height);
        }
    }
}
