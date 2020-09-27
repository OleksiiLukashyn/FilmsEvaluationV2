using FilmsEvaluationV2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FilmsEvaluationV2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Film> Films { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<FilmActors> FilmActors { get; set; }
        public DbSet<FilmDirectors> FilmDirectors { get; set; }
        public DbSet<FilmGenres> FilmGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FilmActors>()
                 .HasKey(e => new { e.FilmId, e.ActorId });

            modelBuilder.Entity<FilmDirectors>()
                 .HasKey(e => new { e.FilmId, e.DirectorId });

            modelBuilder.Entity<FilmGenres>()
                 .HasKey(e => new { e.FilmId, e.GenreId });

            modelBuilder.Entity<FilmPlaylists>()
                 .HasKey(e => new { e.FilmId, e.PlaylistId });
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
