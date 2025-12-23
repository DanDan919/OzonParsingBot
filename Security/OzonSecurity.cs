using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net.Http;

namespace Security
{
    public static class OzonSecurity
    {
        public static HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", RandomUA());
            client.DefaultRequestHeaders.Add("Accept-Language", "ru-RU,ru;q=0.9");
            return client;
        }

        public static IWebDriver CreateWebDriver()
        {
            var options = new ChromeOptions();

            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument("--start-maximized");
            options.AddExcludedArgument("enable-automation");
            options.AddAdditionalOption("useAutomationExtension", false);
            options.AddArgument($"--user-agent={RandomUA()}");

            return new ChromeDriver(options);
        }

        private static string RandomUA()
        {
            string[] ua =
            {
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64)",
                "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7)",
                "Mozilla/5.0 (X11; Linux x86_64)"
            };

            return ua[new Random().Next(ua.Length)];
        }
    }
}