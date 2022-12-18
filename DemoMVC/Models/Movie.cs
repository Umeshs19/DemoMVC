using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Movie
    {
        [Display(Name="Movie Id")] 
        public int Id { get; set; }
        [Display(Name = "Movie Name")]
        public string Name { get; set; }
        [Display(Name = "Year of Release")]
        public int Year { get; set; }
        [Display(Name = "Movie Rating")]
        public int Rating { get; set; }
    }
}
