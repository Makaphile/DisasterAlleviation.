using DisasterAlleviation.Models;

namespace DisasterAlleviation.Services
{
    public interface IDonationService
    {
        IEnumerable<Donation> GetAll();
        Donation? GetById(int id);
        void Create(Donation model);
    }
}

