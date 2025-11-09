namespace DesignPatterns.Iterator.MusicPlayer
{
    public interface IIterator<T>
    {
        public bool HasNext();
        public T Next();
    }
}
