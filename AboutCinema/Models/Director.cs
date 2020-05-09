using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutCinema.Models
{
    public class Director
    {
        [Key]
        public int DirectorID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
