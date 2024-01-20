using App.Controllers.Rest;
using App.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        MediaRestController _mediaRestController;

        public HomeController()
        {
            _mediaRestController = new MediaRestController();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var hostInfo = Request.Host;
            var files = _mediaRestController.GetAll()
                .Select(file => { 
                    var mediaURL = $"{file.FilePath}";
                    return new MediaViewModel
                    {
                        Caption = file.Caption,
                        FilePath = mediaURL
                    };
                });

            return View(files);
        }

        [HttpGet, Route("privacy")]
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
