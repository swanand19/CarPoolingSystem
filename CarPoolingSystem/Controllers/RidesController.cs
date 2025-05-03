using Microsoft.AspNetCore.Mvc;

namespace CarPoolingSystem.Controllers
{
    public class RidesController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
