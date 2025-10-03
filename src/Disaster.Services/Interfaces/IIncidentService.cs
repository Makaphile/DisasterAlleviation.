using DisasterAlleviation.Models;

namespace DisasterAlleviation.Services
{
    public interface IIncidentService
    {
        IEnumerable<Incident> GetAll();
        Incident? GetById(int id);
        void Create(Incident model);
    }
}

