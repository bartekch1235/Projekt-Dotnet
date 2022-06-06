using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Dotnet.Data;
using Projekt_Dotnet.Models;

namespace Projekt_Dotnet.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Projekt_Dotnet.Data.OgloszenieContext _context;

        public DeleteModel(Projekt_Dotnet.Data.OgloszenieContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Ogloszenie Ogloszenie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Ogloszenie == null)
            {
                return NotFound();
            }

            var ogloszenie = await _context.Ogloszenie.FirstOrDefaultAsync(m => m.ID == id);

            if (ogloszenie == null)
            {
                return NotFound();
            }
            else 
            {
                Ogloszenie = ogloszenie;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Ogloszenie == null)
            {
                return NotFound();
            }
            var ogloszenie = await _context.Ogloszenie.FindAsync(id);

            if (ogloszenie != null)
            {
                Ogloszenie = ogloszenie;
                _context.Ogloszenie.Remove(Ogloszenie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
