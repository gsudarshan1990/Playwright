import {test, expect} from '@playwright/test';

test('fill the search box and press enter',async({page}) => {
    await page.goto('https://www.playwright.dev/');
    await page.waitForSelector('//button[@class="DocSearch DocSearch-Button"]');
    await page.click('//button[@class="DocSearch DocSearch-Button"]');
    await page.fill('input[placeholder="Search docs"]','API');
    await page.waitForTimeout(5000);
    await page.press('input[placeholder="Search docs"]','Enter');
    await page.waitForTimeout(5000);
    await expect(page.locator('h1')).toHaveText('Mock browser APIs');
    await page.close();
});