using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class CategoryController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
