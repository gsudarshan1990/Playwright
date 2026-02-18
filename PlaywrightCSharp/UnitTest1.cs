using Microsoft.Playwright;

namespace Playwright_Practice
{
    public class UnitTest1
    {
        [Fact]
        public async Task OpenGoogle()
        {
            using var playwright = await Playwright.CreateAsync();

            await using var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions()
                {
                    Headless = false
                }
                );
            var page = await browser.NewPageAsync();

            await page.GotoAsync("https://www.google.com");

            await Task.Delay(3000);

        }
    }
}
