namespace MusicWebApp1.Models
{
    public sealed class Song
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Lyrics { get; set; } = null!;

        public int AlbumId { get; set; }
        public Album? Album { get; set; }

        public IEnumerable<Artist> Artists = new List<Artist>();
        public IEnumerable<ArtistSong> ArtistSongs = new List<ArtistSong>();
    }
}
