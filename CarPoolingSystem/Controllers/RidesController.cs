using CarPoolingSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarPoolingSystem.Controllers
{
    [Route("[controller]")]
    public class RidesController : Controller
    {

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
        public IActionResult Create(RideVM model)
        {
            return RedirectToAction("Index", "Dashboard");
        }


    }
}
