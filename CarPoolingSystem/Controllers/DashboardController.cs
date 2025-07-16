using Microsoft.AspNetCore.Mvc;

namespace CarPoolingSystem.Controllers
{

    [Route("[controller]")]
    public class DashboardController : Controller
    {
        [Route("/")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
