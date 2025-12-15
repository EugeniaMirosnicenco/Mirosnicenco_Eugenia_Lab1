using Microsoft.AspNetCore.Mvc;

namespace Mirosnicenco_Eugenia_Lab1.Controllers
{
    public class Controller1 : Controller
    {
        public string Index()
        {
            return "Hello";
        }

        public string Salut()
        {
            return "Salutare, utilizator!";
        }

        public string Afisare(string an, int nr)
        {
            return $"Salutare, utilizator cu numarul {nr}! Este anul {an}";
        }

    }

}
