namespace DesignPatterns.Prototype.Shapes
{
    public interface IGraphicShape
    {
        public string GetInfo();
        public IGraphicShape Clone();
    }
}
