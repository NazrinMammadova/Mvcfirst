using Microsoft.AspNetCore.Mvc;

namespace main1.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
