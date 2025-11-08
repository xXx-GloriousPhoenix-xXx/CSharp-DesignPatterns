namespace DesignPatterns.Decorator.CharacterAI
{
    public sealed class DescriptionText(IText text) : DecoratedText(text)
    {
        public override string Render() => $"*{InnerText.Render()}*";
    }
}
