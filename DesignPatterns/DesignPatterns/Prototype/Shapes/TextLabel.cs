namespace DesignPatterns.Prototype.Shapes
{
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
}
