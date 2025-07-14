using CarPoolingSystem.Tables;
using CarPoolingSystem.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarPoolingSystem.Controllers
{
    [Route("[controller]/[action]")]
    public class UsersController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UsersController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(UserVM model)
        {
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    IsDriver = model.IsDriver,
                    UserName = model.UserName
                };

                IdentityResult result =  await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //now user should be signed in
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    foreach(IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("Register", error.Description);
                    }
                    return View(model);
                }
            }
            else
            {
                ViewBag.ErrorMessage = ModelState.Values.SelectMany(temp => temp.Errors).Select(temp => temp.ErrorMessage);
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
