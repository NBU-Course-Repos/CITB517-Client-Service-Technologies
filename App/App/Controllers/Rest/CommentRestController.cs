using App.Models;
using App.Persistence.Models;
using App.Persistence.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers.Rest
{
    [Route("/rest/api/comment")]
    [ApiController]
    public class CommentRestController : Controller
    {
        private readonly CommentService service;
        public CommentRestController()
        {
            service = new CommentService();
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateCommentRequest request)
        {
            try
            {
                var comment = service.Create(request);
                return Ok(comment);
            }
            catch (Exception e)
            {
                 return StatusCode(403);
            }
        }

        [HttpGet, Route("all/commentator/{commentatorEmail}")]
        public ICollection<CommentViewModel> GetAllByUser(String commentatorEmail) => service.GetAllBy(commentatorEmail);

        [HttpGet, Route("all/media/{mediaId}")]
        public ICollection<CommentViewModel> GetAllByMedia(String mediaId) => service.GetAllBy(Guid.Parse(mediaId));

        [HttpGet, Route("all")]
        public ICollection<Comment> GetAll() => service.GetAll();

        [HttpPost, Route("edit")]
        public void Update(UpdateCommentRequest request) => service.Update(request);
    }
}
