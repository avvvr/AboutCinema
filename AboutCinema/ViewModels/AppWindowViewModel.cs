using AboutCinema.Views;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace AboutCinema.ViewModels
{
    public class AppWindowViewModel:INotifyPropertyChanged
    {
        public RellayCommand HomePageCommand { get; }
        public RellayCommand MoviePageCommand { get; }

        public AppWindowViewModel()
        {

            MoviePageCommand = new RellayCommand(MoviePageAction);
        }

        private void MoviePageAction(object obj)
        {
            CurrentPage = App.MoviesPage;
        }

        private Page _currentPage;

        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                if (_currentPage == value)
                    return;
                _currentPage = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
