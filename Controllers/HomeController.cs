using Microsoft.AspNetCore.Mvc;

namespace Resume_Builder.Controllers
{
    public class HomeController : Controller
    {
        // GET: /  or  /Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/About
        public IActionResult About()
        {
            return View();
        }
    }
}