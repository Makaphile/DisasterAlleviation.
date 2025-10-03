using DisasterAlleviation.Models;

namespace DisasterAlleviation.Services
{
    public interface IVolunteerService
    {
        IEnumerable<Volunteer> GetAll();
        Volunteer? GetById(int id);
        void Create(Volunteer model);
    }
}

