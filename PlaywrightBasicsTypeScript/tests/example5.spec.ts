import {test, expect} from '@playwright/test';

test('Check Chromatic Home Page' , async({page}) => {
    await page.goto('https://www.chromatic.com/');
    await expect(page).toHaveTitle(/Visual testing/);
    const heading = page.locator('h1');
    await expect(heading).toHaveText('Ship flawless UIs with less work');
    await page.screenshot({path:'C:\\Users\\LENOVO\\OneDrive\\Desktop\Copilot Agent\\playwright_practice\\PlaywrightBasicsTypeScript\\tests\screenshot\\screenshot.png'});
    await page.close();
});
        