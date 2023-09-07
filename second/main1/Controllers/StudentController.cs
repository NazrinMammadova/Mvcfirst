using main1.Models;
using Microsoft.AspNetCore.Mvc;

namespace main1.Controllers
{
    public class StudentController : Controller
    {
        private List<Student>_students;
        public IActionResult Index()
        {
            _students = new() {

                new(){Id=1,Name="Student1",GroupId =1 },
                new(){Id=2,Name="Student2",GroupId =1 },
                new(){Id=3,Name="Student3",GroupId =2 },
                new(){Id=4,Name="Student4",GroupId =3 },
                new(){Id=5,Name="Student1",GroupId =4 }



            };
            return View(_students);
        }
    }
}
