using Core;

namespace Parsing;

public class OzonBrut
{
    public async Task RunAsync()
    {
        var browser = new OzonBrowser();
        var page = await browser.CreatePageAsync();

        var scanner = new ProductIdScanner(page);
        await scanner.FindLastAsync();
    }
}