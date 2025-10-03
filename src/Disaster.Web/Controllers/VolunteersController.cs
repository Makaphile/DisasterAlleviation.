using DisasterAlleviation.Models;
using DisasterAlleviation.Services;
using Microsoft.AspNetCore.Mvc;

namespace DisasterAlleviation.Controllers
{
    public class VolunteersController : Controller
    {
        private readonly IVolunteerService _svc;
        public VolunteersController(IVolunteerService svc) => _svc = svc;

        public IActionResult Index()
        {
            var items = _svc.GetAll();
            return View(items);
        }

        public IActionResult Register() => View(new Volunteer());

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Volunteer model)
        {
            if (!ModelState.IsValid) return View(model);
            _svc.Create(model);
            return RedirectToAction(nameof(Index));
        }
    }
}

