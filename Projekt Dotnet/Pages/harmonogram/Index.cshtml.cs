using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Dotnet.Data;
using Projekt_Dotnet.Models;

namespace Projekt_Dotnet.Pages.harmonogram
{
    [Authorize]
    public class IndexModel : PageModel
    {
        
        private readonly Projekt_Dotnet.Data.OgloszenieContext _context;

        public IndexModel(Projekt_Dotnet.Data.OgloszenieContext context)
        {
            _context = context;
        }

        public IList<Harmonogram> Harmonogram { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Harmonogram != null)
            {
                Harmonogram = await _context.Harmonogram.ToListAsync();
            }
        }
    }
}
