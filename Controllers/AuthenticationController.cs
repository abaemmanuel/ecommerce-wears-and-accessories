using ECommerce.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly IAuthService _authService;

        public AuthenticationController(IAuthService authService)
        {
            _authService = authService;
        }
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            var result = await _authService.Login(userName, password);
            if(result != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

    }
}
