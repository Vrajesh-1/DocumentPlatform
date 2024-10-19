namespace DocumentPlatform.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public required ApplicationUser User { get; set; }
    }
}
