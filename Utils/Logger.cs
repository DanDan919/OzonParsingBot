using System;

namespace Utils
{
    public static class Logger
    {
        public static void Info(string msg)
        {
            Console.WriteLine($"[INFO] {DateTime.Now:HH:mm:ss} {msg}");
        }

        public static void Warn(string msg)
        {
            Console.WriteLine($"[WARN] {DateTime.Now:HH:mm:ss} {msg}");
        }
    }
}