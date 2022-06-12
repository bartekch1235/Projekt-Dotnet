using System.ComponentModel.DataAnnotations;

namespace Projekt_Dotnet.Models
{
    public class Harmonogram
    {
        [Required]
        public int Id { get; set; }
        
        public string HowManyDays { get; set; }
        
        public int HowManyHours { get; set; }

        public string People { get; set; }
        
        public string Duties { get; set; }
        public void AddDuty(string newDuty)
        {
            Duties = Duties + ", " + newDuty;
        }
        public void AddPerson(string newPerson)
        {
            People = People +", "+ newPerson;
        }
        public Harmonogram() { }
    }
}
