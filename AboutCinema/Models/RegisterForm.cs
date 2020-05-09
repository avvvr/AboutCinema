using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AboutCinema.Models
{
    public class RegisterForm
    {
        [Required(ErrorMessage = "Wrong nickname")]
        public string Nickname { get; set; }

        [EmailAddress(ErrorMessage = "Wrong email")]
        [Required(ErrorMessage = "Wrong email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Wrong password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Error confirm password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        public bool Validate()
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(this);
            if (!Validator.TryValidateObject(this, context, results, true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                    return false;
                }
                return true;
            }
            else return true;
        }
    }
}
