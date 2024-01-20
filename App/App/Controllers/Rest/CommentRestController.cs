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
        public CommentViewModel? Create([FromBody] CreateCommentRequest request) => service.Create(request);

        [HttpGet, Route("all/{commentatorEmail}")]
        public ICollection<CommentViewModel> GetAllBy(String commentatorEmail) => service.GetAllBy(commentatorEmail);

        [HttpGet, Route("all")]
        public ICollection<Comment> GetAll() => service.GetAll();

        [HttpPost, Route("edit")]
        public void Update(UpdateCommentRequest request) => service.Update(request);
    }
}
