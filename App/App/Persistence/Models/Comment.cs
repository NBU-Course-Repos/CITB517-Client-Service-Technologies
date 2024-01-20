using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Persistence.Models
{
    public class Comment
    {
        public Guid Id { get; set; }
        [Timestamp] public DateTime Timestamp { get; set; }
        [Column(TypeName="text")] public string Content { get; set; }
        public virtual User Commentator { get; set; }
        public string CommentatorEmail { get; set; }
        public Media? Media { get; set; } 
        public Guid? MediaId { get; set; }
    }
}
