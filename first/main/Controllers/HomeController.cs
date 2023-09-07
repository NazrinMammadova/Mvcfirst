using Microsoft.AspNetCore.Mvc;

namespace main.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            return File("~/img/rabbit.webp", "image/jpeg");

        }

    }
}
