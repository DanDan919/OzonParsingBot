using Microsoft.Playwright;

namespace Parsing;

public static class AntiBotDetector
{
    public static bool IsBlocked(IPage page)
    {
        var html = page.ContentAsync().Result;

        return html.Contains("не робот")
            || html.Contains("Access denied")
            || html.Length < 800;
    }
}