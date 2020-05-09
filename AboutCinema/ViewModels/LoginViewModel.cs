using AboutCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AboutCinema.ViewModels
{
    public class LoginViewModel
    {
        public RellayCommand LoginCommand { get; }
        public RellayCommand RegisterCommand { get; }
        public LoginForm LoginForm { get; set; } = new LoginForm();

        public LoginViewModel()
        {
            LoginCommand = new RellayCommand(LoginAction);
            RegisterCommand = new RellayCommand(RegisterAction);

        }
        private void RegisterAction(object obj)
        {
            App.AuthorizationWindowViewModel.CurrentPage = App.RegisterPage;
        }
        private void LoginAction(object obj)
        {
            /*var password = (obj as PasswordBox)?.Password;
            if (LoginForm.Validate())
            {
                //Отправить на сервер запрос
            }
            else
            {
                MessageBox.Show("Wrong mail or password");
            }*/
            AppWindow appWindow = new AppWindow();
            foreach(Window window in App.Current.Windows)
            {
                if (window.Title == "AuthorizationWindow") window.Close();
            }
            appWindow.Show();
            
        }
    }
}
