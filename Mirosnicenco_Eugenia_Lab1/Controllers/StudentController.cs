using Microsoft.AspNetCore.Mvc;

namespace Mirosnicenco_Eugenia_Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new StudentController { Name = "Ana", Age = 21 };
            return View(student);
        }
    }
}
