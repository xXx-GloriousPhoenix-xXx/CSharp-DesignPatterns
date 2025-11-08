namespace DesignPatterns.Decorator
{
    public interface IText
    {
        public string Render();
    }
    public class PlainText(string text) : IText
    {
        private readonly string text = text;
        public string Render() => text;
    }
    public class DecoratedText(IText innerText) : IText
    {
        protected readonly IText InnerText = innerText;
        public virtual string Render() => InnerText.Render();
    }
    public sealed class AccentText(IText inner) : DecoratedText(inner)
    {
        public override string Render() => $"**{InnerText.Render()}**";
    }
    public sealed class NameText(IText text) : DecoratedText (text)
    {
        public override string Render() => $"`{InnerText.Render()}`";
    }
    public sealed class DescriptionText(IText text) : DecoratedText(text)
    {
        public override string Render() => $"*{InnerText.Render()}*";
    }
    public sealed class ClarificationText(IText text) : DecoratedText(text)
    {
        public override string Render() => $"({InnerText.Render()})";
    }
    public sealed class BotCallText(IText text) : DecoratedText(text)
    {
        public override string Render() => $"[{InnerText.Render()}]";
    }
    public sealed class DirectSpeechText(IText text) : DecoratedText(text)
    {
        public override string Render() => $"\"{InnerText.Render()}\"";
    }
    public sealed class DialogueLineText(IText text) : DecoratedText(text)
    {
        public override string Render() => $"— {InnerText.Render()}";
    }
}
