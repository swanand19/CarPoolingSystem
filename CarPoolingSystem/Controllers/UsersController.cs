using CarPoolingSystem.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CarPoolingSystem.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        [HttpGet]
        [Route("[action]")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("[action]")]
        public IActionResult Register(UserVM model)
        {
            if (ModelState.IsValid)
            {

            }
            else
            {
                ViewBag.ErrorMessage = ModelState.FirstOrDefault();
                return View(model);
            }
        }

        [Route("[action]")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
