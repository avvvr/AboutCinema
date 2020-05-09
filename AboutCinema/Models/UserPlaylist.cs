using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutCinema.Models
{
    public class UserPlaylist
    {
        [Key]
        public int UserPlaylistID { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Playlist Playlist { get; set; }
    }
}
