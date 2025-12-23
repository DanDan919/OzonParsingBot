using Microsoft.Playwright;

namespace Parsing;

public static class ProductValidator
{
    public static bool Exists(IPage page)
    {
        return page.Locator("[data-widget='webProductHeading']")
                   .CountAsync().Result > 0;
    }
}