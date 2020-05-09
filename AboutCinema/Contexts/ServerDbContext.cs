using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AboutCinema.Models;

namespace AboutCinema.Contexts
{
    class ServerDbContext: DbContext
    {
            public ServerDbContext() : base("MsSqlServer")
            {
            }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        //public DbSet<MovieActor> MovieActors { get; set; }
        //public DbSet<MovieDirector> MovieDirectors { get; set; }
        //public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        //public DbSet<PlaylistMovie> PlaylistMovies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPlaylist> UserPlaylists { get; set; }

    } //
}
