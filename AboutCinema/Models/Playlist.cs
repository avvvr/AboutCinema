using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutCinema.Models
{
    public class Playlist
    {
        [Key]
        public int PlaylistID { get; set; }
        [Required]
        public string PlaylistTitle { get; set; }
        public string PlaylistPic { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
