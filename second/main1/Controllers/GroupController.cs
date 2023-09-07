using main1.Model;
using Microsoft.AspNetCore.Mvc;

namespace main1.Controllers
{
    public class GroupController : Controller
    {
        private List<Group> _groups;
        public IActionResult Index(int?id)
        {
            _groups = new()
        {
            new Group { Id = 1,Name ="P333",Size=23 },
            new Group { Id = 2,Name = "P334",Size=23 },
            new Group { Id = 3,Name = "P335",Size= 24},
            new Group { Id = 4,Name = "P336",Size = 26}

        };
            

            return View(_groups);
        }
    }
}
