namespace MusicWebApp1.Models
{
    public class Artist
    {
        public Artist()
        {
            ArtistSong = new List<ArtistSong>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<ArtistSong> ArtistSongs { get; set; }
    }
}
