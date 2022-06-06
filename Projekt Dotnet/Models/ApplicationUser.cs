using Microsoft.AspNetCore.Identity;

namespace Projekt_Dotnet.Models
{
    public class ApplicationUser:IdentityUser
    {
        public bool IsOwner { get; set; }

    }
}
