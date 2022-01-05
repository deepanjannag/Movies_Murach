using System.ComponentModel.DataAnnotations;

namespace MovieList.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a year")]
        [Range(1889, 2999, ErrorMessage = "Year must be after 1889")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please give a rating")]
        [Range(1, 5, ErrorMessage = "Must be between 1 & 5")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please enter a Genre")]
        public string GenreId { get; set; }                     //This is needed only if you have to do more with Genre than just reading
        public Genre Genre { get; set; }
    }
}
