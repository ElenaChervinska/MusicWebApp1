namespace MusicWebApp1.Models
{
    public sealed class Album
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;

        public IEnumerable<Song> Songs { get; set; } = new List<Song>();
    }
}
