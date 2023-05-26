namespace MusicWebApp1.Models
{
    public sealed class ArtistSong
    {
        public int Id { get; set; }

        public int SongId { get; set; }
        public Song? Song { get; set; }

        public int ArtistId { get; set; }
        public Artist? Artist { get; set; }
    }
}
