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

namespace Projekt_Dotnet.Pages.zaginiecia
{
    public class EditModel : PageModel
    {
        private readonly Projekt_Dotnet.Data.OgloszenieContext _context;

        public EditModel(Projekt_Dotnet.Data.OgloszenieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Zaginiecie Zaginiecie { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Zaginiecie == null)
            {
                return NotFound();
            }

            var zaginiecie =  await _context.Zaginiecie.FirstOrDefaultAsync(m => m.Id == id);
            if (zaginiecie == null)
            {
                return NotFound();
            }
            Zaginiecie = zaginiecie;
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

            _context.Attach(Zaginiecie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZaginiecieExists(Zaginiecie.Id))
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

        private bool ZaginiecieExists(int id)
        {
          return (_context.Zaginiecie?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
