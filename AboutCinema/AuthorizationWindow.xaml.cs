using AboutCinema.Contexts;
using AboutCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AboutCinema
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
            DataContext = App.AuthorizationWindowViewModel;
            App.AuthorizationWindowViewModel.CurrentPage = App.LoginPage;
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            using ( var context = new ServerDbContext())
            {
                context.Users.Add(new User() { Nickname = "nick", Password = "pass", Email = "aaaa@gmail.com" });
                context.SaveChanges();
            }
        }*/
    }
}
