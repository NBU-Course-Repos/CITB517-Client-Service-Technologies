using App.Persistence.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class CommentViewModel
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public string Content { get; set; }
        public string CommentatorEmail { get; set; }
    }
}
