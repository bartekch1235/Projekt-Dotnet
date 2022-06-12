using System.ComponentModel.DataAnnotations;

namespace Projekt_Dotnet.Models
{
    public class Zaginiecie
    {
        [Required]
        public int Id { get; set; }
        [Display(Name ="Opis")]
        public string Name { get; set; }
        [Display(Name = "Miejsca w którym ostatnio widzano zwierzaka")]
        public string Place { get; set; }
        public bool IsActive  { get; set; }
     
        public Zaginiecie() { }


    }
}
