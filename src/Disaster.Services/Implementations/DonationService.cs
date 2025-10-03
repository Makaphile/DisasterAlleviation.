using DisasterAlleviation.Data;
using DisasterAlleviation.Models;
using Microsoft.EntityFrameworkCore;

namespace DisasterAlleviation.Services
{
    public class DonationService : IDonationService
    {
        private readonly ApplicationDbContext _db;
        public DonationService(ApplicationDbContext db) => _db = db;

        public IEnumerable<Donation> GetAll() => _db.Donations.OrderByDescending(d => d.DateDonated).ToList();

        public Donation? GetById(int id) => _db.Donations.Find(id);

        public void Create(Donation model)
        {
            _db.Donations.Add(model);
            _db.SaveChanges();
        }
    }
}

