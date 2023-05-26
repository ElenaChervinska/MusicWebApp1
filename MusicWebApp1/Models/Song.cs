namespace MusicWebApp1.Models
{
    public class Song
    {
        public Song()
        {
            ArtistSongs = new List<ArtistSong>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lyrics { get; set; }
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
        public virtual ICollection<ArtistSong> ArtistSongs { get; set; }
    }
}
