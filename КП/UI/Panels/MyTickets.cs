using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using КП.Core.Entities;
using КП.Infrastructure;

namespace КП.UI.Panels
{
    public partial class MyTickets : UserControl
    {
        private int pageSize = 50;
        private int currentPage = 0;
        private bool sortAsc = true;

        public MyTickets()
        {
            InitializeComponent();
            ParentChanged += ShowTickets;
            sortAscBtn.Click += (s, e) => { sortAsc = true; ShowTickets(null, EventArgs.Empty); };
            sortDescBtn.Click += (s, e) => { sortAsc = false; ShowTickets(null, EventArgs.Empty); };
            searchTextBox.TextChanged += (s, e) => { currentPage = 0; ShowTickets(null, EventArgs.Empty); };
            sortFieldSelect.SelectedIndexChanged += (s, e) => { ShowTickets(null, EventArgs.Empty); };
            resetFiltersBtn.Click += ClearFilter_Click;
        }

        public async void ShowTickets(object sender, EventArgs e)
        {
            var tickets = await GetTickets();

            myTicketsListDataGrid.Columns.Clear(); // Очистка старых столбцов

            myTicketsListDataGrid.Columns.Add("TicketNumber", "Номер билета");
            myTicketsListDataGrid.Columns.Add("SeatNumber", "Номер места");
            myTicketsListDataGrid.Columns.Add("DepartureTime", "Дата отправления");
            myTicketsListDataGrid.Columns.Add("PassengerFirstName", "Имя пассажира");
            myTicketsListDataGrid.Columns.Add("PassengerLastName", "Фамилия пассажира");
            myTicketsListDataGrid.Columns.Add("DocumentNumber", "Номер документа");
            myTicketsListDataGrid.Columns.Add("DocumentType", "Тип документа");

            myTicketsListDataGrid.Rows.Clear();

            int index = 1;
            foreach (var ticket in tickets)
            {
                var rowIndex = myTicketsListDataGrid.Rows.Add(
                    index++,
                    ticket.SeatNumber,
                    ticket.Flight.DepartureTime.ToDateTimeUnspecified().ToString("yyyy-MM-dd HH:mm"),
                    ticket.Booking.Passenger.FirstName,
                    ticket.Booking.Passenger.LastName,
                    ticket.Booking.Passenger.DocumentNumber,
                    ticket.Booking.Passenger.DocumentType
                );
            }
        }

        private void ClearFilter_Click(object sender, EventArgs e)
        {
            sortAsc = true;
            currentPage = 0;
            searchTextBox.Text = string.Empty;
            sortFieldSelect.SelectedIndex = 0;
        }


        public async Task<List<Ticket>> GetTickets()
        {
            var context = DbContextFactory.CreateContext();

            var query = context.Tickets
                .Include(t => t.Flight)
                .Include(t => t.Flight.DepartureAirport)
                .Include(t => t.Flight.ArrivalAirport)
                .Include(t => t.Booking)
                .Include(t => t.Booking.Passenger)
                .Include(t => t.Booking.Passenger.DocumentType)
                .Where(t => t.Booking.UserId == UserSession.UserId);

            var search = searchTextBox.Text.ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                query = query
                    .Where(t => t.Booking.Passenger.FirstName.ToLower().StartsWith(search)
                            || t.Booking.Passenger.LastName.ToLower().StartsWith(search)
                            || t.Booking.Passenger.DocumentNumber.StartsWith(search));
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

        private Expression<Func<Ticket, object>> OrderByIndex(int index)
        {
            return index switch
            {
                1 => t => t.Flight.ArrivalTime,
                2 => t => t.Status.Name,
                3 => t => t.Flight.DepartureAirport.Name,
                4 => t => t.Flight.ArrivalAirport.Name,
                _ => t => t.Flight.DepartureTime,
            };
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
    }
}
