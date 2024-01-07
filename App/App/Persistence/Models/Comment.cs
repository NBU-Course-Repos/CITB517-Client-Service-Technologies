using System.ComponentModel.DataAnnotations;

namespace App.Persistence.Models
{
    public class Comment
    {
        public Guid Id { get; set; }

        [Required]
        public string Timestamp { get; set; } = null!;

        public string Content { get; set; } = null!;

        public User Commentator { get; set; } = null!;
    }
}
