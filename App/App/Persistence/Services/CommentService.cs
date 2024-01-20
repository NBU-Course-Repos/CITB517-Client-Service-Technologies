using App.Models;
using App.Persistence.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.Services
{
    public class CommentService : PersistenceService<Comment, Guid>
    {
        readonly UserService userService;
        public CommentService()
        {
            userService = new UserService();
        }
        private IEnumerable<Comment> FindAllBy(String commentatorEmail) =>
            databaseContext.Comments
            .Where(comment => comment.Commentator.Email == commentatorEmail)
            .OrderBy(comment => comment.Timestamp);
        
        public List<CommentViewModel> GetAllBy(string commentatorEmail) =>
            FindAllBy(commentatorEmail)
            .Select<Comment, CommentViewModel>(comment => persistenceModelToDTO(comment))
            .ToList();

        //public void DeleteAllBy(String commentatorEmail) => FindAllBy(commentatorEmail)
        //    .(comment => databaseContext.Comments.Remove(comment));

        public CommentViewModel? Create(CreateCommentRequest request) {
            if (userService.GetById(request.CommentatorEmail) == null) throw new Exception("Invalid user");
            var comment = Create(new Comment() { 
                Id = Guid.NewGuid(), 
                Timestamp = DateTime.Now, 
                Content = request.Content,
                CommentatorEmail = request.CommentatorEmail }
            );
            return persistenceModelToDTO(comment);
        }

        public void Update(UpdateCommentRequest request)
        {
            var comment = GetById(request.Id)!;
            comment.Content = request.Content;
            comment.Timestamp = DateTime.Now;
            Update(comment);
        }

        private CommentViewModel persistenceModelToDTO(Comment comment) => new CommentViewModel()
        {
            Id = comment.Id,
            Content = comment.Content,
            CommentatorEmail = comment.CommentatorEmail,
            Timestamp = comment.Timestamp
        };
    }

    public class CreateCommentRequest
    {
        public String Content { get; set; }
        public String CommentatorEmail { get; set; }
    }

    public class UpdateCommentRequest
    {
        public Guid Id { get; set; }
        public String Content { get; set; }
    }
}
