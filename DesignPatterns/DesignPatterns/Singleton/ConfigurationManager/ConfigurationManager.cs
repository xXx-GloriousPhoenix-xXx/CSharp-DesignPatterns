namespace DesignPatterns.Singleton.ConfigurationManager
{
    public interface IConfigurationManager
    {
        public void LoadSettings();
        public string GetSetting(string key);
        public void SetSetting(string key, string value);
        public void ShowSettings();
    }
    public class ConfigurationManager : IConfigurationManager
    {
        private static readonly Lazy<ConfigurationManager> instance = new(() => new ConfigurationManager());
        private readonly object @lock = new();
        private readonly Dictionary<string, string> settings = [];
        public static ConfigurationManager Instance => instance.Value;
        public void LoadSettings()
        {
            Console.WriteLine("Loading the deafult settings...");
            lock (@lock)
            {
                settings["Theme"] = "Light";
                settings["Language"] = "EN";
                settings["Version"] = "1.0.0";
            }
            Console.WriteLine("Default settings loaded.");
        }
        public string GetSetting(string key)
        {
            lock (@lock)
            {
                return settings.TryGetValue(key, out var value)
                    ? value
                    : "Setting not found";
            }
        }
        public void SetSetting(string key, string value)
        {
            lock (@lock)
            {
                settings[key] = value;
            }
        }
        public void ShowSettings()
        {
            Decorator.ShowWrapped(
                "Settings",
                () =>
                {
                    lock (@lock)
                    {
                        foreach (var pair in settings)
                        {
                            Console.WriteLine($"{pair.Key}: {pair.Value}");
                        }
                    }
                },
                decorationCharLength: 5
            );
        }
    }
    public static class Decorator
    {
        public static void ShowWrapped(string name, Action printingOperation, char decorationChar = '=', int decorationCharLength = 1, int spaceLength = 1)
        {
            var totalLength = 2 * (decorationCharLength) + 2 * spaceLength + name.Length;
            var startLine =
                string.Concat(Enumerable.Repeat(decorationChar, decorationCharLength)) +
                string.Concat(Enumerable.Repeat(" ", spaceLength)) +
                name +
                string.Concat(Enumerable.Repeat(" ", spaceLength)) +
                string.Concat(Enumerable.Repeat(decorationChar, decorationCharLength));
            var endLine = string.Concat(Enumerable.Repeat(decorationChar, totalLength));
            Console.WriteLine(startLine);
            printingOperation();
            Console.WriteLine(endLine);
        }
    }
}
