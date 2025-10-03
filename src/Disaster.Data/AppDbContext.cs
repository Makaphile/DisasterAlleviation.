using Microsoft.EntityFrameworkCore;
using Disaster.Web.Models;

namespace Disaster.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Donation> Donations { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
    }
}
