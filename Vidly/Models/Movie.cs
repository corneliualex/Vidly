using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a name")]
        public string Name { get; set; }

        [Display(Name ="Release date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name ="Date added")]
        public DateTime DateAdded { get; set; }

        [Range(1,20)]
        [Display(Name ="Number in Stock")]
        public int NumberInStock { get; set; }

        [Display(Name = "Genres")]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }

    }
}
