using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Dotnet.Models;

namespace Projekt_Dotnet.Pages
{
    public class OgloszeniaModel : PageModel
    {
        private readonly Projekt_Dotnet.Data.OgloszenieContext _context;

        public OgloszeniaModel(Projekt_Dotnet.Data.OgloszenieContext context)
        {
            _context = context;
        }

        public IList<Ogloszenie> Ogloszenie { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Ogloszenie != null)
            {
                Ogloszenie = await _context.Ogloszenie.ToListAsync();
            }
        }
    }
}
