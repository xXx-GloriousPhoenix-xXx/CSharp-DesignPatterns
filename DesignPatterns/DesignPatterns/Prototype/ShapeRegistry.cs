namespace DesignPatterns.Prototype
{
    public class ShapeRegistry
    {
        private readonly Dictionary<string, IGraphicShape> registry = [];

        public const string DefaultCircle = "DefaultCircle";
        public const string DefaultRectangle = "DefaultRectangle";
        public const string DefaultTextLabel = "DefaultTextLabel";

        public void AddPrototype(string key, IGraphicShape shape)
        {
            registry[key] = shape;
        }
        public IGraphicShape GetPrototype(string key)
        {
            return registry[key].Clone();
        }
        public void LoadDefaultShapes()
        {
            AddPrototype(DefaultCircle, new Circle { Color = "Black", Radius = 5 });
            AddPrototype(DefaultRectangle, new Rectangle { Color = "Gray", Width = 10, Height = 10 });
            AddPrototype(DefaultTextLabel, new TextLabel { Text = "Default Text", FontSize = 12 });
        }
    }
}
