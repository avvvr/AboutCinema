using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutCinema.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Movie Movie { get; set; }
        [Required]
        public string CommentText { get; set; }
        [Required]
        public DateTime WritingDate { get; set; }
    }
}
