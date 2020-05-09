using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Net.Mime.MediaTypeNames;
//using System.Drawing.Common;

namespace AboutCinema.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [Required]
        public string Nickname { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; } // не знаю нужно ли
        public string ProfilePic { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<UserPlaylist> UserPlaylists { get; set; }
    }
}
