namespace DesignPatterns.Decorator.CharacterAI
{
    public sealed class DialogueLineText(IText text) : DecoratedText(text)
    {
        public override string Render() => $"— {InnerText.Render()}";
    }
}
