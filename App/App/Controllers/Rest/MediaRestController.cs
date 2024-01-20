using App.Persistence.Services;
using Microsoft.AspNetCore.Mvc;
using App.Persistence.Models; 

namespace App.Controllers.Rest
{
    [Route("/rest/api/media")]
    [ApiController]
    public class MediaRestController : Controller
    {
        private MediaService service;
        public MediaRestController()
        {
            service = new MediaService();
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateMediaRequest request) => Ok(service.Create(request));

        [HttpGet, Route("all")]
        public IEnumerable<Media> GetAll() => service.GetAll();
    }
}