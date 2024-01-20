using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("/about")]
    public class AboutController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
