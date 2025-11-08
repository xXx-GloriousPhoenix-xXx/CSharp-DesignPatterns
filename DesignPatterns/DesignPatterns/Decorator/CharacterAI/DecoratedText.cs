namespace DesignPatterns.Decorator.CharacterAI
{
    public class DecoratedText(IText innerText) : IText
    {
        protected readonly IText InnerText = innerText;
        public virtual string Render() => InnerText.Render();
    }
}
