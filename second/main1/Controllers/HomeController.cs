using Microsoft.AspNetCore.Mvc;

namespace main1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();

        }

        public IActionResult About()
        {

            return View();

        }
    }
}
