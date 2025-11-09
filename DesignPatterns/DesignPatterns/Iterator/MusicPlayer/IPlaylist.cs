namespace DesignPatterns.Iterator.MusicPlayer
{
    public interface IPlaylist
    {
        public IIterator<Track> CreateIterator();
    }
}
