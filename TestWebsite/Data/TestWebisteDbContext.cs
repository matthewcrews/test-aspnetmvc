using Microsoft.EntityFrameworkCore;
using TestWebsite.Models;

namespace TestWebsite.Data
{
    public class TestWebsiteDbContext : DbContext
    {
        public TestWebsiteDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
