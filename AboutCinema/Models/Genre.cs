using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutCinema.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        [Required]
        public string GenreName { get; set; }
        [Required]
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
