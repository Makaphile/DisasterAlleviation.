using DisasterAlleviation.Data;
using DisasterAlleviation.Models;

namespace DisasterAlleviation.Services
{
    public class VolunteerService : IVolunteerService
    {
        private readonly ApplicationDbContext _db;
        public VolunteerService(ApplicationDbContext db) => _db = db;

        public IEnumerable<Volunteer> GetAll() => _db.Volunteers.OrderBy(v => v.FullName).ToList();

        public Volunteer? GetById(int id) => _db.Volunteers.Find(id);

        public void Create(Volunteer model)
        {
            _db.Volunteers.Add(model);
            _db.SaveChanges();
        }
    }
}

