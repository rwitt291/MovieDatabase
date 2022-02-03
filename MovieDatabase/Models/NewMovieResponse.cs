using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieDatabase.Models
{
    public class NewMovieResponse
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required(ErrorMessage = "Please enter a valid Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter a valid Year")]
        public ushort Year { get; set; }
        [Required(ErrorMessage = "Please enter a valid Director")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Please enter a valid Rating")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

        //build foreign key relationship
        public int CategoryID { get; set; }
        [Required]
        public Category Category { get; set; }

    }
}
