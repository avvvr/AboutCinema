namespace AboutCinema.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class finally_initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                    {
                        ActorID = c.Int(nullable: false, identity: true),
                        ActorName = c.String(nullable: false),
                        ActorSecondName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ActorID);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Rating = c.Int(),
                        AgeRestriction = c.Int(nullable: false),
                        PremiereDate = c.DateTime(nullable: false),
                        Country = c.String(nullable: false),
                        MoviePic = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.MovieID);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        CommentID = c.Int(nullable: false, identity: true),
                        CommentText = c.String(nullable: false),
                        WritingDate = c.DateTime(nullable: false),
                        Movie_MovieID = c.Int(nullable: false),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentID)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .Index(t => t.Movie_MovieID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        ProfilePic = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.UserPlaylists",
                c => new
                    {
                        UserPlaylistID = c.Int(nullable: false, identity: true),
                        Playlist_PlaylistID = c.Int(nullable: false),
                        User_UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserPlaylistID)
                .ForeignKey("dbo.Playlists", t => t.Playlist_PlaylistID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_UserID, cascadeDelete: true)
                .Index(t => t.Playlist_PlaylistID)
                .Index(t => t.User_UserID);
            
            CreateTable(
                "dbo.Playlists",
                c => new
                    {
                        PlaylistID = c.Int(nullable: false, identity: true),
                        PlaylistTitle = c.String(nullable: false),
                        PlaylistPic = c.String(),
                    })
                .PrimaryKey(t => t.PlaylistID);
            
            CreateTable(
                "dbo.Directors",
                c => new
                    {
                        DirectorID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SecondName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DirectorID);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        GenreName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.MovieActors",
                c => new
                    {
                        Movie_MovieID = c.Int(nullable: false),
                        Actor_ActorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Movie_MovieID, t.Actor_ActorID })
                .ForeignKey("dbo.Movies", t => t.Movie_MovieID, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.Actor_ActorID, cascadeDelete: true)
                .Index(t => t.Movie_MovieID)
                .Index(t => t.Actor_ActorID);
            
            CreateTable(
                "dbo.PlaylistMovies",
                c => new
                    {
                        Playlist_PlaylistID = c.Int(nullable: false),
                        Movie_MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Playlist_PlaylistID, t.Movie_MovieID })
                .ForeignKey("dbo.Playlists", t => t.Playlist_PlaylistID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieID, cascadeDelete: true)
                .Index(t => t.Playlist_PlaylistID)
                .Index(t => t.Movie_MovieID);
            
            CreateTable(
                "dbo.DirectorMovies",
                c => new
                    {
                        Director_DirectorID = c.Int(nullable: false),
                        Movie_MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Director_DirectorID, t.Movie_MovieID })
                .ForeignKey("dbo.Directors", t => t.Director_DirectorID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieID, cascadeDelete: true)
                .Index(t => t.Director_DirectorID)
                .Index(t => t.Movie_MovieID);
            
            CreateTable(
                "dbo.GenreMovies",
                c => new
                    {
                        Genre_GenreID = c.Int(nullable: false),
                        Movie_MovieID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_GenreID, t.Movie_MovieID })
                .ForeignKey("dbo.Genres", t => t.Genre_GenreID, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.Movie_MovieID, cascadeDelete: true)
                .Index(t => t.Genre_GenreID)
                .Index(t => t.Movie_MovieID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GenreMovies", "Movie_MovieID", "dbo.Movies");
            DropForeignKey("dbo.GenreMovies", "Genre_GenreID", "dbo.Genres");
            DropForeignKey("dbo.DirectorMovies", "Movie_MovieID", "dbo.Movies");
            DropForeignKey("dbo.DirectorMovies", "Director_DirectorID", "dbo.Directors");
            DropForeignKey("dbo.Comments", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.UserPlaylists", "User_UserID", "dbo.Users");
            DropForeignKey("dbo.UserPlaylists", "Playlist_PlaylistID", "dbo.Playlists");
            DropForeignKey("dbo.PlaylistMovies", "Movie_MovieID", "dbo.Movies");
            DropForeignKey("dbo.PlaylistMovies", "Playlist_PlaylistID", "dbo.Playlists");
            DropForeignKey("dbo.Comments", "Movie_MovieID", "dbo.Movies");
            DropForeignKey("dbo.MovieActors", "Actor_ActorID", "dbo.Actors");
            DropForeignKey("dbo.MovieActors", "Movie_MovieID", "dbo.Movies");
            DropIndex("dbo.GenreMovies", new[] { "Movie_MovieID" });
            DropIndex("dbo.GenreMovies", new[] { "Genre_GenreID" });
            DropIndex("dbo.DirectorMovies", new[] { "Movie_MovieID" });
            DropIndex("dbo.DirectorMovies", new[] { "Director_DirectorID" });
            DropIndex("dbo.PlaylistMovies", new[] { "Movie_MovieID" });
            DropIndex("dbo.PlaylistMovies", new[] { "Playlist_PlaylistID" });
            DropIndex("dbo.MovieActors", new[] { "Actor_ActorID" });
            DropIndex("dbo.MovieActors", new[] { "Movie_MovieID" });
            DropIndex("dbo.UserPlaylists", new[] { "User_UserID" });
            DropIndex("dbo.UserPlaylists", new[] { "Playlist_PlaylistID" });
            DropIndex("dbo.Comments", new[] { "User_UserID" });
            DropIndex("dbo.Comments", new[] { "Movie_MovieID" });
            DropTable("dbo.GenreMovies");
            DropTable("dbo.DirectorMovies");
            DropTable("dbo.PlaylistMovies");
            DropTable("dbo.MovieActors");
            DropTable("dbo.Genres");
            DropTable("dbo.Directors");
            DropTable("dbo.Playlists");
            DropTable("dbo.UserPlaylists");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.Movies");
            DropTable("dbo.Actors");
        }
    }
}
