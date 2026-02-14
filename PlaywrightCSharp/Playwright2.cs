using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Playwright;

namespace Playwright_Practice
{
    public class Playwright2
    {
        [Fact]
        public async Task OpenExample() {
            // Launching the playwright object

            using var playwright = await Playwright.CreateAsync();

            await using var browser = await playwright.Chromium.LaunchAsync(
                new BrowserTypeLaunchOptions
                {
                    Headless = false
                }

                );

              var page = await browser.NewPageAsync();

            await page.GotoAsync("https://example.com");

            await Task.Delay(3000);

            
                
        }
            

    }
}
