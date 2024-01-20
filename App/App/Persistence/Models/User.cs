using System.ComponentModel.DataAnnotations;

namespace App.Persistence.Models
{
    public class User
    {
        [Key]
        public String Email { get; set; }

        public String DisplayName { get; set; } = "User";

        public ICollection<Comment> Comments { get; } = new List<Comment>();

        public ICollection<Media> Uploads { get; } = new List<Media>();
        // TODO Persist secrets somehow
    }
}