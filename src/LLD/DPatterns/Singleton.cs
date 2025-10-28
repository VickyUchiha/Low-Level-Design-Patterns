using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.src.LLD.DPatterns
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());
        public static Logger Instance => _instance.Value;

        private Logger() { }
        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now}]{message}");
        }
    }

    public class Singleton
    {
        public static void NotMain(string[] args)
        {
            Logger.Instance.Log("Hi Singleton!");
        }
    }
}
