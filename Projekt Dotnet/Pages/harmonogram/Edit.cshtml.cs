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

namespace Projekt_Dotnet.Pages.harmonogram
{
    public class EditModel : PageModel
    {
        private readonly Projekt_Dotnet.Data.OgloszenieContext _context;

        public EditModel(Projekt_Dotnet.Data.OgloszenieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Harmonogram Harmonogram { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Harmonogram == null)
            {
                return NotFound();
            }

            var harmonogram =  await _context.Harmonogram.FirstOrDefaultAsync(m => m.Id == id);
            if (harmonogram == null)
            {
                return NotFound();
            }
            Harmonogram = harmonogram;
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

            _context.Attach(Harmonogram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HarmonogramExists(Harmonogram.Id))
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

        private bool HarmonogramExists(int id)
        {
          return (_context.Harmonogram?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
