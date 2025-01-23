using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Linq.Expressions;
using КП.Core.Entities;
using КП.Infrastructure;

namespace КП.UI.Panels
{
    public partial class ShowUsers : UserControl
    {
        private int pageSize = 50;
        private int currentPage = 0;
        private bool sortAsc = true;

        public ShowUsers()
        {
            InitializeComponent();

            ParentChanged += LoadUsers;
            ParentChanged += CreateMainMenu;

            sortAscBtn.Click += (s, e) => { sortAsc = true; LoadUsers(null, EventArgs.Empty); };
            sortDescBtn.Click += (s, e) => { sortAsc = false; LoadUsers(null, EventArgs.Empty); };
            searchTextBox.TextChanged += (s, e) => { currentPage = 0; LoadUsers(null, EventArgs.Empty); };
            sortFieldSelect.SelectedIndexChanged += (s, e) => { LoadUsers(null, EventArgs.Empty); };
            roleSelectBox.SelectedIndexChanged += (s, e) => { LoadUsers(null, EventArgs.Empty); };
            resetFiltersBtn.Click += ClearFilter_Click;
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

        public async void LoadUsers(object sender, EventArgs e)
        {
            var users = await GetUsers();

            usersListDataGrid.Columns.Clear();
            usersListDataGrid.Columns.Add("Id", "ID");
            usersListDataGrid.Columns.Add("Email", "Email");
            usersListDataGrid.Columns.Add("FirstName", "Имя");
            usersListDataGrid.Columns.Add("LastName", "Фамилия");
            usersListDataGrid.Columns.Add("Phone", "Телефон");
            usersListDataGrid.Columns.Add("Role", "Роль");

            usersListDataGrid.Rows.Clear();
            foreach (var user in users)
            {
                usersListDataGrid.Rows.Add(user.Id, user.Email, user.FirstName, user.LastName, user.PhoneNumber, user.Role.Name);
            }
        }

        private void ClearFilter_Click(object sender, EventArgs e)
        {
            sortAsc = true;
            currentPage = 0;
            searchTextBox.Text = string.Empty;
            sortFieldSelect.SelectedIndex = 0;
            roleSelectBox.SelectedIndex = 3;
        }

        public async Task<List<User>> GetUsers()
        {
            var context = DbContextFactory.CreateContext();
            var query = context.Users
                .Include(u => u.Role)
                .Where(u => u.RoleId == roleSelectBox.SelectedIndex + 1);

            var search = searchTextBox.Text.ToLower();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(u => u.FirstName.ToLower().StartsWith(search) ||
                                         u.LastName.ToLower().StartsWith(search) ||
                                         u.Email.ToLower().StartsWith(search));
            }

            int sortIndex = sortFieldSelect.SelectedIndex;
            query = sortAsc ? query.OrderBy(OrderByIndex(sortIndex)) : query.OrderByDescending(OrderByIndex(sortIndex));

            query = query.Skip(pageSize * currentPage).Take(pageSize);
            return await query.ToListAsync();
        }

        private Expression<Func<User, object>> OrderByIndex(int index)
        {
            return index switch
            {
                1 => u => u.LastName,
                2 => u => u.Email,
                _ => u => u.FirstName,
            };
        }
        private void ShowUsers_SizeChanged(object sender, EventArgs e)
        {
            usersListDataGrid.Location = new Point(this.Width / 2 - usersListDataGrid.Width / 2, this.Height / 2 - usersListDataGrid.Height / 2);
            roleLabel.Location = new Point(usersListDataGrid.Location.X + usersListDataGrid.Width + 40, usersListDataGrid.Location.Y + roleLabel.Height);
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
