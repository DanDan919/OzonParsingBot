using Microsoft.Playwright;
using Core;

namespace Parsing;

public class ProductIdScanner
{
    private readonly IPage _page;

    public ProductIdScanner(IPage page)
    {
        _page = page;
    }

    public async Task FindLastAsync()
    {
        long id = 120_000_000;
        long step = 1_000_000;

        while (true)
        {
            var url = $"https://www.ozon.ru/product/{id}/";
            await _page.GotoAsync(url, new() { Timeout = 60000 });

            if (AntiBotDetector.IsBlocked(_page))
            {
                await Task.Delay(TimeSpan.FromMinutes(3));
                continue;
            }

            if (ProductValidator.Exists(_page))
            {
                Console.WriteLine($"OK {id}");
                id += step;
                step *= 2;
            }
            else
            {
                Console.WriteLine($"STOP {id}");
                break;
            }

            await RateLimiter.RandomDelay();
        }

        // бинарный поиск будет тут
    }
}