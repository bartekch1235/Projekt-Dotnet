using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Dotnet.Models;

namespace Projekt_Dotnet.Pages
{
    public class OgloszeniaModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly Data.OgloszenieContext _context;

        public OgloszeniaModel(Data.OgloszenieContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<Ogloszenie> Ogloszenie { get; set; } = default!;

        public async Task OnGetAsync()
        {
            ViewData["user"] = "user";
            if (_userManager.GetUserName(User) == null)
                ViewData["user"] = "brak";
           
            
            if (_context.Ogloszenie != null)
            {
                Ogloszenie = await _context.Ogloszenie.ToListAsync();
            }
        }
    
    }
}
/*






        private readonly ClaimsIdentity_zad_6.Data.ApplicationDbContext _context;

        public IndexModel(ClaimsIdentity_zad_6.Data.ApplicationDbContext context, Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
 */
