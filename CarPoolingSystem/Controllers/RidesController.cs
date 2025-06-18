using CarPoolingSystem.DbEntities;
using CarPoolingSystem.Tables;
using CarPoolingSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarPoolingSystem.Controllers
{
    [Route("[controller]")]
    public class RidesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RidesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("[action]")]
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RideVM model)
        {
            return RedirectToAction("Index", "Dashboard");
        }


    }
}
