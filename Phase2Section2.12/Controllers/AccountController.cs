using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.Identity;

namespace Phase2Section2._12.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string ReturnUrl)
        {
            ViewData["ReturnUrl"] = ReturnUrl;
            return View();
        }

        public IActionResult LoginAction(string userid, string password, string ReturnUrl)
        {
            var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name, userid)
                }, CookieAuthenticationDefaults.AuthenticationScheme);

            var principal = new ClaimsPrincipal(identity);

            var login = HttpContext.SignInAsync(DefaultAuthenticationTypes.ApplicationCookie, principal);

            return Redirect(ReturnUrl);
        }
    }
}
