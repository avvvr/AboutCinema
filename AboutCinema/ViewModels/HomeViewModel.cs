using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using AboutCinema.Contexts;
using AboutCinema.Models;
using JetBrains.Annotations;

namespace AboutCinema.ViewModels
{
    public class HomeViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<Movie> Novelty { get; set; } //Новинки
        public ObservableCollection<Movie> MarvelMovies { get; set; }
        public ObservableCollection<Movie> VictoryDayMovies { get; set; }
        public ObservableCollection<Movie> GoodMoodMovies { get; set; }
        public ObservableCollection<Movie> DisneyMovies { get; set; }
        public ObservableCollection<Movie> BeatFilmFestivalMovies { get; set; }
        public ObservableCollection<Movie> AnimeMovies { get; set; }
        public ObservableCollection<Movie> OscarMovies { get; set; }
        public ObservableCollection<Movie> AboutEpidemicsMovies { get; set; }
        public ObservableCollection<Movie> LiteratureInMovies { get; set; }
        private readonly ServerDbContext _dbContext; //добавила readonly
        public HomeViewModel()
        {
            _dbContext = new ServerDbContext();

            var resultQuery = _dbContext.Playlists.FirstOrDefault(t => t.PlaylistTitle == "Новинки").Movies;
            Novelty = new ObservableCollection<Movie>(resultQuery);
            Novelty.CollectionChanged += (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                                          => OnPropertyChanged(nameof(Novelty));
            OnPropertyChanged(nameof(Novelty));

            resultQuery = _dbContext.Playlists.FirstOrDefault(t => t.PlaylistTitle == "Киновселенная MARVEL").Movies;
            MarvelMovies = new ObservableCollection<Movie>(resultQuery);
            MarvelMovies.CollectionChanged += (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                                               => OnPropertyChanged(nameof(MarvelMovies));
            OnPropertyChanged(nameof(MarvelMovies));

            resultQuery = _dbContext.Playlists.FirstOrDefault(t => t.PlaylistTitle == "День Победы: главные фильмы и сериалы").Movies;
            VictoryDayMovies = new ObservableCollection<Movie>(resultQuery);
            VictoryDayMovies.CollectionChanged += (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                                                   => OnPropertyChanged(nameof(VictoryDayMovies));
            OnPropertyChanged(nameof(VictoryDayMovies));

            resultQuery = _dbContext.Playlists.FirstOrDefault(t => t.PlaylistTitle == "Хорошее настроение").Movies;
            GoodMoodMovies = new ObservableCollection<Movie>(resultQuery);
            GoodMoodMovies.CollectionChanged += (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                                                 => OnPropertyChanged(nameof(GoodMoodMovies));
            OnPropertyChanged(nameof(GoodMoodMovies));

            resultQuery = _dbContext.Playlists.FirstOrDefault(t => t.PlaylistTitle == "Детям: Disney").Movies;
            DisneyMovies = new ObservableCollection<Movie>(resultQuery);
            DisneyMovies.CollectionChanged += (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                                               => OnPropertyChanged(nameof(DisneyMovies));
            OnPropertyChanged(nameof(DisneyMovies));

            resultQuery = _dbContext.Playlists.FirstOrDefault(t => t.PlaylistTitle == "Beat Film Festival: лучшее").Movies;
            BeatFilmFestivalMovies = new ObservableCollection<Movie>(resultQuery);
            BeatFilmFestivalMovies.CollectionChanged += (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                                                         => OnPropertyChanged(nameof(BeatFilmFestivalMovies));
            OnPropertyChanged(nameof(BeatFilmFestivalMovies));

            resultQuery = _dbContext.Playlists.FirstOrDefault(t => t.PlaylistTitle == "Аниме").Movies;
            AnimeMovies = new ObservableCollection<Movie>(resultQuery);
            AnimeMovies.CollectionChanged += (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                                              => OnPropertyChanged(nameof(AnimeMovies));
            OnPropertyChanged(nameof(AnimeMovies));

            resultQuery = _dbContext.Playlists.FirstOrDefault(t => t.PlaylistTitle == "Лауреты и номинанты \"Оскара\"").Movies;
            OscarMovies = new ObservableCollection<Movie>(resultQuery);
            OscarMovies.CollectionChanged += (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                                              => OnPropertyChanged(nameof(OscarMovies));
            OnPropertyChanged(nameof(OscarMovies));

            resultQuery = _dbContext.Playlists.FirstOrDefault(t => t.PlaylistTitle == "Кино про эпидемии").Movies;
            AboutEpidemicsMovies = new ObservableCollection<Movie>(resultQuery);
            AboutEpidemicsMovies.CollectionChanged += (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                                                       => OnPropertyChanged(nameof(AboutEpidemicsMovies));
            OnPropertyChanged(nameof(AboutEpidemicsMovies));

            resultQuery = _dbContext.Playlists.FirstOrDefault(t => t.PlaylistTitle == "Литература в кино").Movies;
            LiteratureInMovies = new ObservableCollection<Movie>(resultQuery);
            LiteratureInMovies.CollectionChanged += (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                                                     => OnPropertyChanged(nameof(LiteratureInMovies));
            OnPropertyChanged(nameof(LiteratureInMovies));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
