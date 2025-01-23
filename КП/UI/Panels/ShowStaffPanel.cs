using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using КП.Core.Entities;
using КП.Infrastructure;

namespace КП.UI.Panels
{
    public partial class ShowStaffPanel : UserControl
    {
        private int pageSize = 50;
        private int currentPage = 0;
        private bool sortAsc = true;

        public ShowStaffPanel()
        {
            InitializeComponent();

            ParentChanged += ShowStaff;
            ParentChanged += CreateMainMenu;

            sortAscBtn.Click += (s, e) => { sortAsc = true; ShowStaff(null, EventArgs.Empty); };
            sortDescBtn.Click += (s, e) => { sortAsc = false; ShowStaff(null, EventArgs.Empty); };
            searchTextBox.TextChanged += (s, e) => { currentPage = 0; ShowStaff(null, EventArgs.Empty); };
            sortFieldSelect.SelectedIndexChanged += (s, e) => { ShowStaff(null, EventArgs.Empty); };
            resetFiltersBtn.Click += ClearFilter_Click;

            staffListDataGrid.CellEndEdit += StaffListDataGrid_CellEndEdit;
        }

        private async void StaffListDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = staffListDataGrid.Rows[e.RowIndex];
            var context = DbContextFactory.CreateContext();

            // Найти сотрудника по ID
            var staffId = (long)staffListDataGrid.Rows[e.RowIndex].Tag;
            var staff = await context.Staff.Include(s => s.IdNavigation).FirstOrDefaultAsync(s => s.Id == staffId);

            if (staff != null)
            {
                staff.IdNavigation.FirstName = row.Cells["FirstName"].Value.ToString().Trim();
                staff.IdNavigation.LastName = row.Cells["LastName"].Value.ToString().Trim();
                staff.IdNavigation.Email = row.Cells["Email"].Value.ToString().Trim();

                await context.SaveChangesAsync();
            }
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

        public async void ShowStaff(object sender, EventArgs e)
        {
            var staff = await GetStaff();

            staffListDataGrid.Columns.Clear();
            staffListDataGrid.AllowUserToAddRows = true;
            DataGridViewHelper.AddColumn(staffListDataGrid, "FirstName", "Имя", new List<string>() { "ValidateFirstName" });
            DataGridViewHelper.AddColumn(staffListDataGrid, "LastName", "Фамилия", new List<string>() { "ValidateLastName" });
            DataGridViewHelper.AddColumn(staffListDataGrid, "Email", "Email", new List<string>() { "ValidateEmail" });
            staffListDataGrid.Columns.Add(new DataGridViewTextBoxColumn { Name = "Position", HeaderText = "Должность", ReadOnly = true });

            staffListDataGrid.Rows.Clear();

            foreach (var employee in staff)
            {
                var rowIndex = staffListDataGrid.Rows.Add(
                    employee.IdNavigation.FirstName,
                    employee.IdNavigation.LastName,
                    employee.IdNavigation.Email,
                    employee.Position?.Name ?? "Не назначен"
                );
                staffListDataGrid.Rows[rowIndex].Tag = employee.Id;
            }
        }

        private void ClearFilter_Click(object sender, EventArgs e)
        {
            sortAsc = true;
            currentPage = 0;
            searchTextBox.Text = string.Empty;
            sortFieldSelect.SelectedIndex = 0;
        }

        public async Task<List<Staff>> GetStaff()
        {
            var context = DbContextFactory.CreateContext();

            var query = context.Staff
                .Include(s => s.IdNavigation)
                .Include(s => s.Position)
                .AsQueryable();

            var search = searchTextBox.Text.ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                query = query
                    .Where(e => e.IdNavigation.FirstName.ToLower().StartsWith(search)
                            || e.IdNavigation.LastName.ToLower().StartsWith(search)
                            || e.IdNavigation.Email.ToLower().StartsWith(search));
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

        private Expression<Func<Staff, object>> OrderByIndex(int index)
        {
            return index switch
            {
                1 => e => e.IdNavigation.LastName,
                2 => e => e.IdNavigation.Email,
                3 => e => e.Position.Name,
                _ => e => e.IdNavigation.FirstName,
            };
        }

        private void ShowStaffPanel_SizeChanged(object sender, EventArgs e)
        {
            staffListDataGrid.Location = new Point(this.Width / 2 - staffListDataGrid.Width / 2, this.Height / 2 - staffListDataGrid.Height / 2);
            searchLabel.Location = new Point(staffListDataGrid.Location.X + staffListDataGrid.Width + 40, staffListDataGrid.Location.Y + searchLabel.Height);
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
