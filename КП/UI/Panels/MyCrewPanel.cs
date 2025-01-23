using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using КП.Core.Entities;
using КП.Infrastructure;

namespace КП.UI.Panels
{
    public partial class MyCrewPanel : UserControl
    {
        private int pageSize = 50;
        private int currentPage = 0;
        private bool sortAsc = true;

        public MyCrewPanel()
        {
            InitializeComponent();

            var mainMenu = new MainMenu
            {
                Dock = DockStyle.Top
            };
            this.Controls.Add(mainMenu);

            ParentChanged += ShowCrew;
            sortAscBtn.Click += (s, e) => { sortAsc = true; ShowCrew(null, EventArgs.Empty); };
            sortDescBtn.Click += (s, e) => { sortAsc = false; ShowCrew(null, EventArgs.Empty); };
            searchTextBox.TextChanged += (s, e) => { currentPage = 0; ShowCrew(null, EventArgs.Empty); };
            sortFieldSelect.SelectedIndexChanged += (s, e) => { ShowCrew(null, EventArgs.Empty); };
            resetFiltersBtn.Click += ClearFilter_Click;
        }

        public async void ShowCrew(object sender, EventArgs e)
        {
            var crew = await GetCrew();

            myCrewListDataGrid.Columns.Clear();
            myCrewListDataGrid.Columns.Add("FirstName", "Имя");
            myCrewListDataGrid.Columns.Add("LastName", "Фамилия");
            myCrewListDataGrid.Columns.Add("Position", "Должность");

            myCrewListDataGrid.Rows.Clear();

            foreach (var member in crew)
            {
                myCrewListDataGrid.Rows.Add(member.IdNavigation.FirstName, member.IdNavigation.LastName, member.Qualification);
            }
        }

        private void ClearFilter_Click(object sender, EventArgs e)
        {
            sortAsc = true;
            currentPage = 0;
            searchTextBox.Text = string.Empty;
            sortFieldSelect.SelectedIndex = 0;
        }

        public async Task<List<CrewMember>> GetCrew()
        {
            var context = DbContextFactory.CreateContext();

            var userCrewIds = context.CrewAssigments
                .Where(ca => ca.CrewMemberId == UserSession.UserId)
                .Select(ca => ca.CrewId);

            var query = context.CrewMembers
                .Include(cm => cm.IdNavigation)
                .Include(cm => cm.CrewAssigments)
                .Where(cm => cm.CrewAssigments.Any(ca => userCrewIds.Contains(ca.CrewId)));

            var search = searchTextBox.Text.ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(c => c.IdNavigation.FirstName.ToLower().StartsWith(search)
                || c.IdNavigation.LastName.ToLower().StartsWith(search)
                || c.Qualification.ToLower().StartsWith(search));
            }

            int sortIndex = sortFieldSelect.SelectedIndex;
            query = sortAsc ? query.OrderBy(OrderByIndex(sortIndex)) : query.OrderByDescending(OrderByIndex(sortIndex));

            query = query.Skip(pageSize * currentPage).Take(pageSize);
            return await query.ToListAsync();
        }

        private Expression<Func<CrewMember, object>> OrderByIndex(int index)
        {
            return index switch
            {
                1 => c => c.IdNavigation.LastName,
                2 => c => c.Qualification,
                _ => c => c.IdNavigation.FirstName,
            };
        }

        private void MyCrewPanel_SizeChanged(object sender, EventArgs e)
        {
            myCrewListDataGrid.Location = new Point(this.Width / 2 - myCrewListDataGrid.Width / 2, this.Height / 2 - myCrewListDataGrid.Height / 2);
            searchLabel.Location = new Point(myCrewListDataGrid.Location.X + myCrewListDataGrid.Width + 40, myCrewListDataGrid.Location.Y + searchLabel.Height);
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
