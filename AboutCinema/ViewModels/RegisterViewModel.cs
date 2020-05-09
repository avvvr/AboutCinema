using AboutCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AboutCinema.ViewModels
{
    public class RegisterViewModel
    {
        public RegisterForm RegisterForm { get; set; } = new Models.RegisterForm();
        public RellayCommand BackCommand { get; }
        public RellayCommand RegisterCommand { get; }
        public RegisterViewModel()
        {
            BackCommand = new RellayCommand(obj => { App.AuthorizationWindowViewModel.CurrentPage = App.LoginPage; });
            RegisterCommand = new RellayCommand(RegisterAction);
        }
        private void RegisterAction(object obj)
        {
            if (!(obj is Grid grid)) return;

            foreach(var i in grid.Children)
            {
                if (!(i is PasswordBox passwordBox)) continue;
                if (passwordBox.Name == "PasswordTextInput") RegisterForm.Password = passwordBox.Password;
                else RegisterForm.ConfirmPassword = passwordBox.Password; ;
            }

        }
    }
}
