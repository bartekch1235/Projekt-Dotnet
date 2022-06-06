using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt_Dotnet.Data;
using Projekt_Dotnet.Models;

namespace Projekt_Dotnet.Pages
{
    public class EditModel : PageModel
    {
        private readonly Projekt_Dotnet.Data.OgloszenieContext _context;

        public EditModel(Projekt_Dotnet.Data.OgloszenieContext context)
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

            var ogloszenie =  await _context.Ogloszenie.FirstOrDefaultAsync(m => m.ID == id);
            if (ogloszenie == null)
            {
                return NotFound();
            }
            Ogloszenie = ogloszenie;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Ogloszenie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OgloszenieExists(Ogloszenie.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OgloszenieExists(int id)
        {
          return (_context.Ogloszenie?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
