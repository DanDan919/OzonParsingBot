using Microsoft.Playwright;

namespace Core;

public class OzonBrowser
{
    public async Task<IPage> CreatePageAsync()
    {
        var pw = await Playwright.CreateAsync();
        var browser = await pw.Chromium.LaunchAsync(new()
        {
            Headless = false,
            SlowMo = Random.Shared.Next(80, 150)
        });

        var context = await browser.NewContextAsync(new()
        {
            UserAgent = FingerprintFactory.RandomUserAgent(),
            ViewportSize = FingerprintFactory.RandomViewport(),
            Locale = "ru-RU"
        });

        return await context.NewPageAsync();
    }
}