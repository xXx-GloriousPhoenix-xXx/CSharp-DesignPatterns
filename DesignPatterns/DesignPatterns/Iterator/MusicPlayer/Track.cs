namespace DesignPatterns.Iterator.MusicPlayer
{
    public class Track(string title, string author)
    {
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
    }
}
