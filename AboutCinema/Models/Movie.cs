using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutCinema.Models
{
    public class Movie
    {
        [Key]
        public int MovieID { get; set; }
        [Required]
        public string Title { get; set; }
        public int? Rating { get; set; } //рейтинг
        public virtual ICollection<Director> Directors { get; set; }//режиссеры
        [Required]
        public int AgeRestriction { get; set; } //возрастные ограничения
        [Required]
        public DateTime PremiereDate { get; set; } //дата премьеры
        [Required]
        public string Country { get; set; }
        [Required]
        public string MoviePic { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Type { get; set; } //сериал или фильм
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Actor> Actors { get; set; } 
        public virtual ICollection<Playlist> Playlists { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
    }
}
