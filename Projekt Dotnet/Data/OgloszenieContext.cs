using Microsoft.EntityFrameworkCore;
using Projekt_Dotnet.Models;

namespace Projekt_Dotnet.Data
{
    public class OgloszenieContext:DbContext
    {
        public OgloszenieContext (DbContextOptions options ): base(options) { }
        public DbSet<Ogloszenie> Ogloszenie { get; set; }
    }
}
