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

        [Required]
        public string Name { get; set; }

        [Display(Name ="Release date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name ="Date added")]
        public DateTime DateAdded { get; set; }

        [Display(Name ="Number in Stock")]
        public int NumberInStock { get; set; }

        [Display(Name = "Genres")]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }

    }
}
