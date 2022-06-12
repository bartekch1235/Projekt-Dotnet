using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projekt_Dotnet.Data;
using Projekt_Dotnet.Models;

namespace Projekt_Dotnet.Pages.harmonogram
{
    public class CreateModel : PageModel
    {
        private readonly Projekt_Dotnet.Data.OgloszenieContext _context;

        public CreateModel(Projekt_Dotnet.Data.OgloszenieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Harmonogram Harmonogram { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Harmonogram == null || Harmonogram == null)
            {
                return Page();
            }

            _context.Harmonogram.Add(Harmonogram);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
