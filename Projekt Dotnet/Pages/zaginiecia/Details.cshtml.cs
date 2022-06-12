using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projekt_Dotnet.Data;
using Projekt_Dotnet.Models;

namespace Projekt_Dotnet.Pages.zaginiecia
{
    public class DetailsModel : PageModel
    {
        private readonly Projekt_Dotnet.Data.OgloszenieContext _context;

        public DetailsModel(Projekt_Dotnet.Data.OgloszenieContext context)
        {
            _context = context;
        }

      public Zaginiecie Zaginiecie { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Zaginiecie == null)
            {
                return NotFound();
            }

            var zaginiecie = await _context.Zaginiecie.FirstOrDefaultAsync(m => m.Id == id);
            if (zaginiecie == null)
            {
                return NotFound();
            }
            else 
            {
                Zaginiecie = zaginiecie;
            }
            return Page();
        }
    }
}
