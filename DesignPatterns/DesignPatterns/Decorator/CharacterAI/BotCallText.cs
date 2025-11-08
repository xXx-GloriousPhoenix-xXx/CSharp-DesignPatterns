namespace DesignPatterns.Decorator.CharacterAI
{
    public sealed class BotCallText(IText text) : DecoratedText(text)
    {
        public override string Render() => $"[{InnerText.Render()}]";
    }
}
