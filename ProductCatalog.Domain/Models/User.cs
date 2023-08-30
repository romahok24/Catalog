using Microsoft.AspNetCore.Identity;

namespace ProductCatalog.Domain.Models
{
    public class User : IdentityUser
    {
        public bool IsBlocked { get; set; }
    }
}