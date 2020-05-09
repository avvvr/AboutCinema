using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutCinema.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }
        [Required]
        public string ActorName { get; set; }
        [Required]
        public string ActorSecondName { get; set; }
        [Required]
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
