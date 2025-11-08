namespace DesignPatterns.Prototype
{
    public interface IGraphicShape
    {
        public string GetInfo();
        public IGraphicShape Clone();
    }
}
