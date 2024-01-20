using System.ComponentModel.DataAnnotations;

namespace App.Persistence.Models
{
    public class Media
    {
        public Guid Id { get; set; }
        public string FilePath { get; set; } 
        public string Caption { get; set; } 
        public string UploaderEmail { get; set; }
        public User Uploader { get; set; }
        [Timestamp] public DateTime Timestamp { get; set;}
        public ICollection<Comment>? Comments { get;}
    }
}
