using DisasterAlleviation.Models;
using DisasterAlleviation.Services;
using Microsoft.AspNetCore.Mvc;

namespace DisasterAlleviation.Controllers
{
    public class DonationsController : Controller
    {
        private readonly IDonationService _svc;
        public DonationsController(IDonationService svc) => _svc = svc;

        public IActionResult Index()
        {
            var items = _svc.GetAll();
            return View(items);
        }

        public IActionResult Create() => View(new Donation { DateDonated = DateTime.UtcNow });

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Donation model)
        {
            if (!ModelState.IsValid) return View(model);
            _svc.Create(model);
            return RedirectToAction(nameof(Index));
        }
    }
}

