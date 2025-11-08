namespace DesignPatterns.Decorator.CharacterAI
{
    public sealed class AccentText(IText inner) : DecoratedText(inner)
    {
        public override string Render() => $"**{InnerText.Render()}**";
    }
}
