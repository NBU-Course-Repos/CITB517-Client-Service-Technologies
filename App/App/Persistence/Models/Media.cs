namespace App.Persistence.Models
{
    public class Media
    {
        public Guid Id { get; set; }

        public string FilePath { get; set; } = null!;

        public string Caption { get; set; } = null!;

        public string Owner { get; set; } = null!;

        public DateTime Timestamp { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}
