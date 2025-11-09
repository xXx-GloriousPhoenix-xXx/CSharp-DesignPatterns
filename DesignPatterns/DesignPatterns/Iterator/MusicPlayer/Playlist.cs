namespace DesignPatterns.Iterator.MusicPlayer
{
    public class Playlist : IPlaylist
    {
        private readonly List<Track> tracks = [];
        public void Add(Track track) => tracks.Add(track);
        public Track GetTrackAt(int index) => tracks[index];
        public int Count => tracks.Count;
        public IIterator<Track> CreateIterator()
        {
            return new PlaylistIterator(this);
        }
        
    }
}
