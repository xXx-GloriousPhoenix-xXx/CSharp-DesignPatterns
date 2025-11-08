namespace DesignPatterns.Decorator.CharacterAI
{
    public sealed class NameText(IText text) : DecoratedText(text)
    {
        public override string Render() => $"`{InnerText.Render()}`";
    }
}
