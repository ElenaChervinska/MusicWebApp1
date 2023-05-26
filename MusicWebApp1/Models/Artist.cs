namespace MusicWebApp1.Models
{
    public sealed class Artist
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public IEnumerable<Song> Songs { get; set; } = new List<Song>();
        public IEnumerable<ArtistSong> ArtistSongs { get; set; } = new List<ArtistSong>();
    }
}
