using Audit.EntityFramework;
using Microsoft.EntityFrameworkCore;
using TestWebsite.Models;

namespace TestWebsite.Data
{
    [AuditDbContext(Mode = AuditOptionMode.OptOut, IncludeEntityObjects = false, AuditEventType = "{database}_{context}")]
    public class TestWebsiteDbContext : Audit.EntityFramework.AuditDbContext
    {
        //public TestWebsiteDbContext(DbContextOptions options)
        //    : base(options)
        //{

        //}

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
