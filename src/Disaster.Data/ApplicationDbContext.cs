using DisasterAlleviation.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterAlleviation.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Donation> Donations => Set<Donation>();
        public DbSet<Incident> Incidents => Set<Incident>();
        public DbSet<Volunteer> Volunteers => Set<Volunteer>();
    }
}
