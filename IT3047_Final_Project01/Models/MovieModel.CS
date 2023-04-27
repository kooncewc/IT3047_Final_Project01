using System;
using System.ComponentModel.DataAnnotations;

namespace IT3047_Final_Project01.Models
{

    public class MovieModel
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a year.")]
        [Range(1800, 2024, ErrorMessage = "Year must be between 1800 and now.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 10.")]
        public int? Rating { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}
