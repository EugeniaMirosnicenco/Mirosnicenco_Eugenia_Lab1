using Microsoft.AspNetCore.Mvc;
using Mirosnicenco_Eugenia_Lab1.Models;

namespace Mirosnicenco_Eugenia_Lab1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info()
        {
            var student = new Student { Name = "Ana", Age = 21 };
            return View(student);
        }
    }
}
