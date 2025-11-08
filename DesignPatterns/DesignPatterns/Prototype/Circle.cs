namespace DesignPatterns.Prototype
{
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
}
