using DisasterAlleviation.Models;
using DisasterAlleviation.Services;
using Microsoft.AspNetCore.Mvc;

namespace DisasterAlleviation.Controllers
{
    public class IncidentsController : Controller
    {
        private readonly IIncidentService _svc;
        public IncidentsController(IIncidentService svc) => _svc = svc;

        public IActionResult Index()
        {
            var items = _svc.GetAll();
            return View(items);
        }

        public IActionResult Report() => View(new Incident { DateReported = DateTime.UtcNow });

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Report(Incident model)
        {
            if (!ModelState.IsValid) return View(model);
            _svc.Create(model);
            return RedirectToAction(nameof(Index));
        }
    }
}

