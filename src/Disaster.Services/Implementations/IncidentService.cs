using DisasterAlleviation.Data;
using DisasterAlleviation.Models;

namespace DisasterAlleviation.Services
{
    public class IncidentService : IIncidentService
    {
        private readonly ApplicationDbContext _db;
        public IncidentService(ApplicationDbContext db) => _db = db;

        public IEnumerable<Incident> GetAll() => _db.Incidents.OrderByDescending(i => i.DateReported).ToList();

        public Incident? GetById(int id) => _db.Incidents.Find(id);

        public void Create(Incident model)
        {
            _db.Incidents.Add(model);
            _db.SaveChanges();
        }
    }
}

