namespace DesignPatterns.Iterator.MusicPlayer
{
    public class PlaylistIterator : IIterator<Track>
    {
        private readonly Playlist playlist;
        private PlaylistMode playlistMode;
        private int position;

        private List<int> ShaffleAllowPosition = [];

        private readonly Random random = new();
        public PlaylistIterator(Playlist playlist, PlaylistMode playlistMode = PlaylistMode.Normal)
        {
            this.playlist = playlist;
            this.playlistMode = playlistMode;
            RefreshShaffle();

            if (playlistMode == PlaylistMode.Normal)
            {
                position = 0;
            }
            else if (playlistMode == PlaylistMode.Reverse)
            {
                position = playlist.Count - 1;
            }
        }
        public bool HasNext()
        {
            return playlistMode switch
            {
                PlaylistMode.Normal => position < playlist.Count,
                PlaylistMode.Reverse => position >= 0,
                PlaylistMode.Shaffle => true,
                _ => false
            };
        }
        public Track Next()
        {
            if (HasNext())
            {
                switch (playlistMode)
                {
                    case PlaylistMode.Normal:
                        return playlist.GetTrackAt(position++);
                    case PlaylistMode.Reverse:
                        return playlist.GetTrackAt(position--);
                    case PlaylistMode.Shaffle:
                        if (ShaffleAllowPosition.Count == 0)
                        {
                            RefreshShaffle();
                        }
                        var index = random.Next(0, ShaffleAllowPosition.Count);
                        position = ShaffleAllowPosition[index];
                        ShaffleAllowPosition.RemoveAt(index);
                        return playlist.GetTrackAt(position);
                    default:
                        throw new InvalidOperationException("Playlist mode error");
                }
            }
            else
            {
                throw new InvalidOperationException("No more tracks available");
            }
        }
        public void RefreshShaffle()
        {
            ShaffleAllowPosition = Enumerable.Range(0, playlist.Count).ToList();
        }
    }
}
