using CarPoolingSystem.Tables;
using CarPoolingSystem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarPoolingSystem.Controllers
{
    [Route("[controller]/[action]")]
    [AllowAnonymous]
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
        public async Task<ActionResult> Register(RegisterUserVM model)
        {
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    FullName = model.FullName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    IsDriver = model.IsDriver,
                    UserName = model.UserName,
                    CreatedAt = DateTime.Now
                };

                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //now user should be signed in
                    await _signInManager.SignInAsync(user, isPersistent: false);

                    //Add the new user in the AspNetRoles table and assign him role
                    await _userManager.AddToRoleAsync(user, model.UserType);
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginUserVM model, string ReturnUrl)
        {
                if (!ModelState.IsValid)
                {
                    ViewBag.ErrorMessage = ModelState.Values.SelectMany(temp => temp.Errors).Select(temp => temp.ErrorMessage);
                    return View(model);
                }
                else
                {
                    var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.Remember, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        if(!string.IsNullOrEmpty(ReturnUrl) && Url.IsLocalUrl(ReturnUrl))
                        {
                            return LocalRedirect(ReturnUrl);
                        }
                        return RedirectToAction("Index", "Dashboard");
                    }
                    else
                    {
                        ModelState.AddModelError("Login", "Invalid email or password.");
                        return View(model);
                    }
                }
        }

        public async Task<ActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Dashboard");
        }

        public async Task<ActionResult> IsEmailAlreadyUsed(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json(false);
            }
        }
    }
}
