using Microsoft.AspNetCore.Identity;

namespace DocumentPlatform.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Document> Documents { get; set; } = new List<Document>();
    }
}
