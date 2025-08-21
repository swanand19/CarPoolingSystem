using CarPoolingSystem.Tables;
using CarPoolingSystem.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarPoolingSystem.Controllers
{
    [Route("[controller]/[action]")]
    public class RolesController : Controller
    {
        //This controller is for creating, editing and managing roles
        private readonly RoleManager<Role> _roleManager;
        public RolesController(RoleManager<Role> roleManager)
        {
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Create()
        {
            ViewBag.ErrorMessage = null;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(RoleVM model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMessage = ModelState.Values.SelectMany(temp => temp.Errors).Select(temp => temp.ErrorMessage);
                return View(model);
            }
            else
            {
                if(await _roleManager.FindByNameAsync(model.Name) is null)
                {
                    Role role = new Role()
                    {
                        Name = model.Name
                    };
                    await _roleManager.CreateAsync(role);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.ErrorMessage = "Role already exists.";
                    return View(model);
                }
            }
        }
    }
}
