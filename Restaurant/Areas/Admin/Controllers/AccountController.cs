using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant.ViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        public AccountController(UserManager<IdentityUser> _UserManager,SignInManager<IdentityUser> _SignInManager)
        {
            UserManager = _UserManager;
            SignInManager = _SignInManager;
        }

        public UserManager<IdentityUser> UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; }
        [Authorize]
        public IActionResult Index()
        {
            var users = UserManager.Users.ToList();
            return View(users);
        }
        [Authorize]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterModel collection)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Enter email and password");
                return View(collection);
            }
            var User = new IdentityUser
            {
                Email = collection.Email,
                UserName = collection.Email
            };
            var Result = await UserManager.CreateAsync(User, collection.Password);
            if (Result.Succeeded)
            {
                //await SignInManager.SignInAsync(User, isPersistent: false);
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Wrong Email Or Password");
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel collection)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Enter email and password");
                return View();
            }
            var Result = await SignInManager.PasswordSignInAsync(collection.Email, collection.Password, isPersistent: collection.RememberMe, false);
            if (Result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Wrong email or password");
                return View();
            }
        }

        public async Task<ActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
        [Authorize]
        public async Task<ActionResult> Edit(string id)
        {
            var data = await UserManager.FindByIdAsync(id);
            UserChangePasswordModel model = new UserChangePasswordModel();
            model.Email = data.Email;
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(UserChangePasswordModel collection)
        {
            var user = await UserManager.FindByEmailAsync(collection.Email);
            user.PasswordHash = UserManager.PasswordHasher.HashPassword(user,collection.NewPassword);
            var result = await UserManager.UpdateAsync(user);
            return RedirectToAction("Index", "Account");
        }
        [Authorize]
        public async Task<ActionResult> Delete(string id)
        {
            var data = await UserManager.FindByIdAsync(id);
            var Result = await UserManager.DeleteAsync(data);
            return RedirectToAction("Index");
            
            
        }
    }
}
