using Microsoft.EntityFrameworkCore;
using КП.Data;

namespace КП.Infrastructure
{
    public static class DbContextFactory
    {
        public static ApplicationDbContext CreateContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=airtransfer_organization;Username=postgres;Password=20051022", x => x.UseNodaTime());

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
