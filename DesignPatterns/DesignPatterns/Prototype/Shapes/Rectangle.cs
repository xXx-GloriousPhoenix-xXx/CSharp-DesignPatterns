namespace DesignPatterns.Prototype.Shapes
{
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
}
