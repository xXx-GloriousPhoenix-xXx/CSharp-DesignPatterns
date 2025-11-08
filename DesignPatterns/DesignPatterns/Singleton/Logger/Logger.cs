using System;
using System.Collections.Concurrent;

namespace DesignPatterns.Singleton.Logger
{
    public class Logger : ILogger
    {
        private static readonly Lazy<Logger> instance = new(() => new Logger());
        private readonly object @lock = new();
        private readonly List<string> logs = [];
        public static Logger Instance => instance.Value;
        private Logger() { }
        public void Log(string message)
        {
            var logMessage = $"{DateTime.Now:HH:mm:ss} - {message}";
            lock (@lock)
            {
                logs.Add(logMessage);
            }
        }
        public void ShowLogs()
        {
            lock (@lock)
            {
                foreach (var log in logs)
                {
                    Console.WriteLine(log);
                }
            }
        }
    }
}
