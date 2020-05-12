using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using System.ComponentModel;
using AboutCinema.Models;
using AboutCinema.Contexts;

namespace AboutCinema.ViewModels
{
    class AboutMovieBaseViewModel
    {
        public RellayCommand OpenInfCommand { get; }

        public AboutMovieBaseViewModel()
        {
            
        }
    }
}
