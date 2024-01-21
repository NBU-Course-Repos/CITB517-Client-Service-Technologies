using App.Persistence.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        UserService userService;
        
        public HomeController()
        {
            userService = new UserService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
