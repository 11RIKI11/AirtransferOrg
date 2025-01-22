using Microsoft.EntityFrameworkCore;
using NodaTime;
using System.Data;
using System.Linq.Expressions;
using КП.Core.Entities;
using КП.Infrastructure;

namespace КП.UI.Panels
{
    public partial class FlightListPanel : UserControl
    {
        private int pageSize = 50;
        private int currentPage = 0;
        private bool sortAsc = true;
        private bool myFlights = false;

        public FlightListPanel()
        {
            InitializeComponent();
            ParentChanged += ShowFlights;
            sortAscBtn.Click += (s, e) => { sortAsc = true; ShowFlights(null, EventArgs.Empty); };
            sortDescBtn.Click += (s, e) => { sortAsc = false; ShowFlights(null, EventArgs.Empty); };
            searchTextBox.TextChanged += (s, e) => { currentPage = 0; ShowFlights(null, EventArgs.Empty); };
            sortFieldSelect.SelectedIndexChanged += (s, e) => { ShowFlights(null, EventArgs.Empty); };


            showAllFlights.Hide();
            showMyFlightsBtn.Hide();

            if (UserSession.Role == "crew_member")
            {
                showAllFlights.Show();
                showAllFlights.Click += (s, e) => { myFlights = false; ShowFlights(null, EventArgs.Empty); };

                showMyFlightsBtn.Show();
                showMyFlightsBtn.Click += (s, e) => { myFlights = true; ShowFlights(null, EventArgs.Empty); };
            }

        }

        public async void ShowFlights(object sender, EventArgs e)
        {
            var flights = await GetFlights();

            flightListDataGrid.Columns.Clear(); // Очистка старых столбцов

            flightListDataGrid.Columns.Add("Index", "№");
            flightListDataGrid.Columns.Add("DepartureTime", "Дата отправления");
            flightListDataGrid.Columns.Add("ArrivalTime", "Дата прибытия");
            flightListDataGrid.Columns.Add("DepartureAirport", "Аэропорт отправления");
            flightListDataGrid.Columns.Add("ArrivalAirport", "Аэропорт прибытия");
            flightListDataGrid.Columns.Add("Airline", "Компания");
            flightListDataGrid.Columns.Add("Aircraft", "Модель самолета");
            flightListDataGrid.Columns.Add("Status", "Статус");

            var buttonColumn = new DataGridViewButtonColumn()
            {
                Name = "Details",
                HeaderText = "Подробности",
                Text = "Перейти",
                UseColumnTextForButtonValue = true
            };
            flightListDataGrid.Columns.Add(buttonColumn);

            flightListDataGrid.Rows.Clear();

            int index = 1;
            foreach (var flight in flights)
            {
                var rowIndex = flightListDataGrid.Rows.Add(
                    index++,
                    flight.DepartureTime.ToDateTimeUnspecified().ToString("yyyy-MM-dd HH:mm"),
                    flight.ArrivalTime.Value.ToDateTimeUnspecified().ToString("yyyy-MM-dd HH:mm"),
                    flight.DepartureAirport.Name,
                    flight.ArrivalAirport.Name,
                    flight.Airline.Name,
                    flight.Aircraft.Model.ModelName,
                    flight.Status.Name,
                    "Перейти"
                );

                flightListDataGrid.Rows[rowIndex].Tag = flight.Id;
            }

            flightListDataGrid.CellContentClick -= FlightListDataGrid_CellContentClick;
            flightListDataGrid.CellContentClick += FlightListDataGrid_CellContentClick;
        }

        private void FlightListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == flightListDataGrid.Columns["Details"].Index && e.RowIndex >= 0)
            {
                var flightId = (long)flightListDataGrid.Rows[e.RowIndex].Tag;
                PanelManager.SwitchTo<MainPanel>(new { id = flightId });//TODO поменяй на нужную панель
            }
        }

        public async Task<List<Flight>> GetFlights()
        {
            var context = DbContextFactory.CreateContext();

            var nowDate = LocalDateTime.FromDateTime(DateTime.Now);
            var query = context.Flights
                .Include(f => f.Airline)
                .Include(f => f.DepartureAirport)
                .Include(f => f.ArrivalAirport)
                .Include(f => f.Aircraft)
                .ThenInclude(a => a.Model)
                .Include(f => f.Status)
                .Where(f => f.DepartureTime >= nowDate);

            if (myFlights)
            {
                query = query.Include(f => f.Crew).ThenInclude(f => f.CrewAssigments);
                query = query.Where(f => f.Crew.CrewAssigments.Any(ca => ca.CrewMemberId == UserSession.UserId));
            }

            var search = searchTextBox.Text.ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                query = query
                    .Where(f => f.DepartureAirport.Name.ToLower().StartsWith(search)
                || f.ArrivalAirport.Name.ToLower().StartsWith(search)
                || f.Aircraft.RegistationNumber.ToString().StartsWith(search)
                || f.Airline.Name.ToLower().StartsWith(search));
            }

            DateTime? departureDate = DateTime.Now;
            if (departureDate.HasValue && departureDate != DateTime.Now)
            {
                var departureLocalDate = LocalDateTime.FromDateTime(DateTime.Now);
                query = query.Where(f => f.DepartureTime >= departureLocalDate);
            }

            int sortIndex = sortFieldSelect.SelectedIndex;
            if (sortAsc)
            {
                query = query.OrderBy(OrderByIndex(sortIndex));
            }
            else
            {
                query = query.OrderByDescending(OrderByIndex(sortIndex));
            }

            query = query.Skip(pageSize * currentPage).Take(pageSize);
            return await query.ToListAsync();
        }

        private Expression<Func<Flight, object>> OrderByIndex(int index)
        {
            return index switch
            {
                1 => f => f.ArrivalTime,
                2 => f => f.Status,
                3 => f => f.DepartureAirport.Name,
                4 => f => f.ArrivalAirport.Name,
                _ => f => f.DepartureTime,
            };
        }

        private void FlightListPanel_SizeChanged(object sender, EventArgs e)
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
            showMyFlightsBtn.Location = new Point(flightListDataGrid.Location.X + flightListDataGrid.Width + 40, flightListDataGrid.Location.Y + showMyFlightsBtn.Height);
            searchLabel.Location = new Point(flightListDataGrid.Location.X + flightListDataGrid.Width + 40, flightListDataGrid.Location.Y + showMyFlightsBtn.Height - searchTextBox.Height);
            searchTextBox.Location = new Point(searchLabel.Location.X, searchLabel.Location.Y + searchTextBox.Height);
            showMyFlightsBtn.Location = new Point(searchTextBox.Location.X, searchTextBox.Location.Y + showMyFlightsBtn.Height);
            showAllFlights.Location = new Point(showMyFlightsBtn.Location.X, showMyFlightsBtn.Location.Y + showMyFlightsBtn.Height + 10);
            sortLabel.Location = new Point(showAllFlights.Location.X, showAllFlights.Location.Y + showAllFlights.Height + 10);
            sortFieldLabel.Location = new Point(sortLabel.Location.X, sortLabel.Location.Y + sortLabel.Height);
            sortFieldSelect.Location = new Point(sortFieldLabel.Location.X, sortFieldLabel.Location.Y + sortFieldLabel.Height);
            sortAscBtn.Location = new Point(sortFieldSelect.Location.X, sortFieldSelect.Location.Y + sortFieldSelect.Height + 10);
            sortDescBtn.Location = new Point(sortAscBtn.Location.X, sortAscBtn.Location.Y + sortAscBtn.Height + 10);
        }
    }
}
