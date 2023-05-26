using Microsoft.EntityFrameworkCore;

namespace MusicWebApp1.Models
{
    public class MusicAPIContext
        : DbContext
    {
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<ArtistSong> ArtistSongs { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Album> Albums { get; set; }
        public MusicAPIContext(DbContextOptions<MusicAPIContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
