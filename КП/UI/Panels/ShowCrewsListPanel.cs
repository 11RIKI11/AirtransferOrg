using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using КП.Core.Entities;
using КП.Infrastructure;

namespace КП.UI.Panels
{
    public partial class ShowCrewsListPanel : UserControl
    {
        private int pageSize = 50;
        private int currentPage = 0;
        private bool sortAsc = true;

        public ShowCrewsListPanel()
        {
            InitializeComponent();

            ParentChanged += ShowCrewsList;
            ParentChanged += CreateMainMenu;

            sortAscBtn.Click += (s, e) => { sortAsc = true; ShowCrewsList(null, EventArgs.Empty); };
            sortDescBtn.Click += (s, e) => { sortAsc = false; ShowCrewsList(null, EventArgs.Empty); };
            searchTextBox.TextChanged += (s, e) => { currentPage = 0; ShowCrewsList(null, EventArgs.Empty); };
            sortFieldSelect.SelectedIndexChanged += (s, e) => { ShowCrewsList(null, EventArgs.Empty); };
            resetFiltersBtn.Click += ClearFilter_Click;
        }

        private void CreateMainMenu(object? sender, EventArgs e)
        {
            ParentChanged -= CreateMainMenu;
            var mainMenu = new MainMenu
            {
                Dock = DockStyle.Top  // Устанавливаем DockStyle.Top для фиксации в верхней части
            };

            this.Controls.Add(mainMenu);
            mainMenu.BringToFront();  // Выводим панель на передний план
        }

        public async void ShowCrewsList(object sender, EventArgs e)
        {
            var crews = await GetCrews();

            crewListDataGrid.Columns.Clear();
            crewListDataGrid.Columns.Add("Id", "ID Экипажа");
            crewListDataGrid.Columns.Add("CrewName", "Название Экипажа");
            crewListDataGrid.Columns.Add("MemberCount", "Количество Членов Экипажа");

            var buttonColumn = new DataGridViewButtonColumn()
            {
                Name = "Details",
                HeaderText = "Подробности",
                Text = "Перейти",
                UseColumnTextForButtonValue = true
            };
            crewListDataGrid.Columns.Add(buttonColumn);

            crewListDataGrid.Rows.Clear();

            foreach (var crew in crews)
            {
                crewListDataGrid.Rows.Add(crew.crew.Id, crew.crew.Name, crew.countMember);
            }

            crewListDataGrid.CellContentClick -= CrewListDataGrid_CellContentClick;
            crewListDataGrid.CellContentClick += CrewListDataGrid_CellContentClick;
        }

        private void CrewListDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == crewListDataGrid.Columns["Details"].Index && e.RowIndex >= 0)
            {
                var crewId = Convert.ToInt64(crewListDataGrid.Rows[e.RowIndex].Cells["Id"].Value);
                PanelManager.SwitchTo<MyCrewPanel>(new { crewId = crewId });
            }
        }

        private void ClearFilter_Click(object sender, EventArgs e)
        {
            sortAsc = true;
            currentPage = 0;
            searchTextBox.Text = string.Empty;
            sortFieldSelect.SelectedIndex = 0;
        }

        public async Task<List<(Crew crew, int countMember)>> GetCrews()
        {
            var context = DbContextFactory.CreateContext();

            var query = context.Crews
                .Include(c => c.CrewAssigments)
                .AsQueryable();

            var search = searchTextBox.Text.ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(c => c.Name.ToLower().StartsWith(search));
            }

            int sortIndex = sortFieldSelect.SelectedIndex;
            query = sortAsc ? query.OrderBy(OrderByIndex(sortIndex)) : query.OrderByDescending(OrderByIndex(sortIndex));

            var resultQuery = query.Select(q => new { Crew = q, CountMember = q.CrewAssigments.Count() });

            query = query.Skip(pageSize * currentPage).Take(pageSize);
            var result = await resultQuery.ToListAsync();

            return result.Select(x => (x.Crew, x.CountMember)).ToList();
        }

        private Expression<Func<Crew, object>> OrderByIndex(int index)
        {
            return index switch
            {
                1 => c => c.Name,
                _ => c => c.Id,
            };
        }

        private void ShowCrewsListPanel_SizeChanged(object sender, EventArgs e)
        {
            crewListDataGrid.Location = new Point(this.Width / 2 - crewListDataGrid.Width / 2, this.Height / 2 - crewListDataGrid.Height / 2);
            searchLabel.Location = new Point(crewListDataGrid.Location.X + crewListDataGrid.Width + 40, crewListDataGrid.Location.Y + searchLabel.Height);
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
