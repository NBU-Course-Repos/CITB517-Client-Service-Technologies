namespace App.Models
{
    public class CommentViewModel
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Content { get; set; }
        public string CommentatorEmail { get; set; }
        public Guid? MediaId { get; set; }

    }
}
