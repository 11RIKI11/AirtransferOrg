using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq.Expressions;
using КП.Core.Entities;
using КП.Infrastructure;

namespace КП.UI.Panels
{
    public partial class ShowAirlinesPanel : UserControl
    {
        private int pageSize = 50;
        private int currentPage = 0;
        private bool sortAsc = true;

        public ShowAirlinesPanel()
        {
            InitializeComponent();

            ParentChanged += ShowAirlines;
            ParentChanged += CreateMainMenu;

            sortAscBtn.Click += (s, e) => { sortAsc = true; ShowAirlines(null, EventArgs.Empty); };
            sortDescBtn.Click += (s, e) => { sortAsc = false; ShowAirlines(null, EventArgs.Empty); };
            searchTextBox.TextChanged += (s, e) => { currentPage = 0; ShowAirlines(null, EventArgs.Empty); };
            sortFieldSelect.SelectedIndexChanged += (s, e) => { ShowAirlines(null, EventArgs.Empty); };
            resetFiltersBtn.Click += ClearFilter_Click;
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

        public async void ShowAirlines(object sender, EventArgs e)
        {
            var airlines = await GetAirlines();

            airlinesListDataGrid.Columns.Clear();

            airlinesListDataGrid.Columns.Add("Name", "Название");
            airlinesListDataGrid.Columns.Add("Country", "Страна");
            airlinesListDataGrid.Columns.Add("City", "Город");
            airlinesListDataGrid.Columns.Add("Street", "Улица");       
            airlinesListDataGrid.Columns.Add("House", "Дом");
            airlinesListDataGrid.Columns.Add("OGRN", "ОГРН");

            airlinesListDataGrid.Rows.Clear();

            foreach (var airline in airlines)
            {
                airlinesListDataGrid.Rows.Add(
                    airline.Name,
                    airline.Country,
                    airline.City,
                    airline.Street,          
                    airline.BuildingNumb,
                    airline.Ogrn
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

        public async Task<List<Airline>> GetAirlines()
        {
            var context = DbContextFactory.CreateContext();

            var query = context.Airlines.AsQueryable();

            var search = searchTextBox.Text.ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(a => a.Name.ToLower().StartsWith(search)
                                      || a.Country.ToLower().StartsWith(search)
                                      || a.City.ToLower().StartsWith(search));
            }

            int sortIndex = sortFieldSelect.SelectedIndex;
            query = sortAsc ? query.OrderBy(OrderByIndex(sortIndex)) : query.OrderByDescending(OrderByIndex(sortIndex));

            query = query.Skip(pageSize * currentPage).Take(pageSize);
            return await query.ToListAsync();
        }

        private Expression<Func<Airline, object>> OrderByIndex(int index)
        {
            return index switch
            {
                1 => a => a.Country,
                2 => a => a.City,
                3 => a => a.Ogrn,
                _ => a => a.Name,
            };
        }

        private void ShowAirlinesPanel_SizeChanged(object sender, EventArgs e)
        {
            airlinesListDataGrid.Location = new Point(this.Width / 2 - airlinesListDataGrid.Width / 2, this.Height / 2 - airlinesListDataGrid.Height / 2);
            searchLabel.Location = new Point(airlinesListDataGrid.Location.X + airlinesListDataGrid.Width + 40, airlinesListDataGrid.Location.Y + searchLabel.Height);
            searchTextBox.Location = new Point(searchLabel.Location.X, searchLabel.Location.Y + searchTextBox.Height);
            resetFiltersBtn.Location = new Point(searchTextBox.Location.X, searchTextBox.Location.Y + resetFiltersBtn.Height);
            sortLabel.Location = new Point(resetFiltersBtn.Location.X, resetFiltersBtn.Location.Y + resetFiltersBtn.Height + 10);
            sortFieldLabel.Location = new Point(sortLabel.Location.X, sortLabel.Location.Y + sortLabel.Height);
            sortFieldSelect.Location = new Point(sortFieldLabel.Location.X, sortFieldLabel.Location.Y + sortFieldLabel.Height);
            sortAscBtn.Location = new Point(sortFieldSelect.Location.X, sortFieldSelect.Location.Y + sortFieldSelect.Height + 10);
            sortDescBtn.Location = new Point(sortAscBtn.Location.X, sortAscBtn.Location.Y + sortAscBtn.Height + 10);
            sortFieldSelect.SelectedIndex = 0;
        }
    }
}
