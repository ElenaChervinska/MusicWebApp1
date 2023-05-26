using Microsoft.EntityFrameworkCore;

namespace MusicWebApp1.Models
{
    public sealed class MusicApiContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; } = null!;
        public DbSet<Song> Songs { get; set; } = null!;
        public DbSet<Album> Albums { get; set; } = null!;
        public DbSet<ArtistSong> ArtistSongs { get; set; } = null!;

        public MusicApiContext(DbContextOptions<MusicApiContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Artist>()
                .HasMany(a => a.Songs)
                .WithMany(s => s.Artists)
                .UsingEntity<ArtistSong>();
        }
    }
}
