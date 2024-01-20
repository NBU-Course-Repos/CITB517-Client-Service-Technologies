namespace App.Models
{
    public class MediaViewModel
    {
        public Guid Id { get; set; }
        public string FilePath { get; set; } = null!;
        public string Caption { get; set; } = null!;
        public string UploaderEmail { get; set; } = null!;
        public DateTime Timestamp { get; set; }
    }
}
