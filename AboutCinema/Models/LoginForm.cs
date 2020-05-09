using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutCinema.Models
{
    public class LoginForm
    {
        [Required(ErrorMessage = "Wrong email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Wrong password")]
        public string Password { get; set; }

        public bool Validate()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                foreach (var error in results)
                {
                    return false;
                }
                return true;
            }
            else return true;
        }
    }
}
