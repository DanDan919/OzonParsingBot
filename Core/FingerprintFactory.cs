namespace Core;
using Microsoft.Playwright;

public static class FingerprintFactory
{
    private static readonly string[] UA =
    {
        "Mozilla/5.0 (Windows NT 10.0; Win64; x64)...",
        "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7)..."
    };

    public static string RandomUserAgent()
        => UA[Random.Shared.Next(UA.Length)];

    public static ViewportSize RandomViewport()
        => new()
        {
            Width = Random.Shared.Next(1280, 1920),
            Height = Random.Shared.Next(720, 1080)
        };
}