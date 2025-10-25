import {test, expect} from '@playwright/test';

test('Docs Deeper Navigation',async({page}) =>{
    await page.goto('https://playwright.dev/');
    await page.click('a[href="/docs/intro"]');
    await page.click('a[href="/docs/trace-viewer-intro"]');
    await expect(page).toHaveTitle(/Trace Viewer/);
});