namespace DesignPatterns.Decorator.CharacterAI
{
    public sealed class ClarificationText(IText text) : DecoratedText(text)
    {
        public override string Render() => $"({InnerText.Render()})";
    }
}
