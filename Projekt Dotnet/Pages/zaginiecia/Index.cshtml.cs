using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Dotnet.Data;
using Projekt_Dotnet.Models;

namespace Projekt_Dotnet.Pages.zaginiecia
{
    public class IndexAdminModel : PageModel
    {
        private readonly Projekt_Dotnet.Data.OgloszenieContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public IndexAdminModel(Projekt_Dotnet.Data.OgloszenieContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<Zaginiecie> Zaginiecie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ViewData["user"] = "user";
            if (_userManager.GetUserName(User) == null)
                ViewData["user"] = "brak";

            if (_context.Zaginiecie != null)
            {
                Zaginiecie = await _context.Zaginiecie.ToListAsync();
            }
        }
    }
}
