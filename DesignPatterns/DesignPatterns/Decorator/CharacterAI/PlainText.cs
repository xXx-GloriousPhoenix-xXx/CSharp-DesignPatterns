namespace DesignPatterns.Decorator.CharacterAI
{
    public class PlainText(string text) : IText
    {
        private readonly string text = text;
        public string Render() => text;
    }
}
