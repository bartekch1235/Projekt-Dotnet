using System.ComponentModel.DataAnnotations;

namespace Projekt_Dotnet.Models
{
    public class Ogloszenie
    {
        [Required]
        public int ID { get; set; }
        public string gatunek { get; set; }
        public string rasa { get; set; }
        public string imie { get; set; }
        public int wiek { get; set; }
        public string opis { get; set; }
        public Ogloszenie() { }

    }
}
