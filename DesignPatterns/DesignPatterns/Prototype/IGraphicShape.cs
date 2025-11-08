namespace DesignPatterns.Prototype
{
    public interface IGraphicShape
    {
        public string GetInfo();
        public IGraphicShape Clone();
    }
    public class Circle : IGraphicShape
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int Radius { get; set; } = 1;
        public string Color { get; set; } = "Black";
        public string GetInfo()
        {
            return $"Center: ({X}, {Y}), Radius = {Radius}, Color: {Color}";
        }
        public IGraphicShape Clone()
        {
            return new Circle
            {
                X = X,
                Y = Y,
                Radius = Radius,
                Color = Color
            };
        }
    }
    public class Rectangle : IGraphicShape
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int Width { get; set; } = 1;
        public int Height { get; set; } = 1;
        public string Color { get; set; } = "Black";
        public bool IsFilled { get; set; } = false;
        public string GetInfo()
        {
            return $"Padding vector: ({X}, {Y})" +
                   $"Dimensions: {Width} x {Height}" +
                   $"Color: {Color}, IsFilled: {IsFilled}";
        }
        public IGraphicShape Clone()
        {
            return new Rectangle
            {
                X = X,
                Y = Y,
                Width = Width,
                Height = Height,
                Color = Color,
                IsFilled = IsFilled
            };
        }
    }
    public class TextLabel : IGraphicShape
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public string Text { get; set; } = "Sample";
        public string Font { get; set; } = "Times New Roman";
        public int FontSize { get; set; } = 14;
        public string Color { get; set; } = "Black";
        public string GetInfo()
        {
            return $"Padding vector: ({X}, {Y})" +
                   $"Text: {Text}" +
                   $"Font: {Font}, FontSize: {FontSize}" +
                   $"Color: {Color}";
        }
        public IGraphicShape Clone()
        {
            return new TextLabel
            {
                X = X,
                Y = Y,
                Text = Text,
                Font = Font,
                FontSize = FontSize,
                Color = Color
            };
        }
    }
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
