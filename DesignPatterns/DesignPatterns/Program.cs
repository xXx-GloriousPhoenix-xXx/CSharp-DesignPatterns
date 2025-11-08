using DesignPatterns.Builder;
using DesignPatterns.Factory;
using DesignPatterns.Prototype;
using DesignPatterns.Singleton.ConfigurationManager;
using DesignPatterns.Singleton.Logger;
using DesignPatterns.Decorator;

namespace DesignPatterns
{
    public static class MyClass
    {
        public static void Main()
        {
            var text = new PlainText("Hello World");
            var decorated = new AccentText(new BotCallText(text));
            Console.WriteLine(decorated.Render());
        }
    }
}