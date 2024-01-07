using App.Persistence.Data;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Text(int age, string role = "admin")
        {
            return $"Your age is {age} and your role is {role}";
        }
    }
}
