using System.ComponentModel.DataAnnotations;

namespace Projekt_Dotnet.Models
{
    public class Harmonogram
    {
        [Required]
        private int Id;
        [Required]
        public string HowManyDays;
        [Required]
        public int HowManyHours;
        [Required]
        public string Duties;
        public void AddDuty(string newDuty)
        {
            Duties = Duties + ", " + newDuty;
        }
    }
}
