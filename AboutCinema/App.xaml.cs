using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AboutCinema.ViewModels;
using AboutCinema.Views;

namespace AboutCinema
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ViewModels.AuthorizationWindowViewModel AuthorizationWindowViewModel { get; set; } = new AuthorizationWindowViewModel();
        public static ViewModels.LoginViewModel LoginViewModel { get; set; } = new LoginViewModel();
        public static ViewModels.RegisterViewModel RegisterViewModel { get; set; } = new RegisterViewModel();
        public static Login LoginPage = new Login();
        public static Register RegisterPage = new Register();

        public static ViewModels.AppWindowViewModel AppWindowViewModel { get; set; } = new AppWindowViewModel();
        public static ViewModels.HomeViewModel HomeViewModel { get; set; } = new HomeViewModel();
        public static Home HomePage = new Home();
    }
}
