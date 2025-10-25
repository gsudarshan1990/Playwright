import {test, expect} from '@playwright/test';

test('navigates to doc page', async({page})=> {
    await page.goto('https://playwright.dev/');
    await page.click("a[href='/docs/intro']");
    await expect(page).toHaveURL('https://playwright.dev/docs/intro');
});

test('intentional failure example', async({page}) => {
    await page.goto('https://playwright.dev/');
    await page.click("a[href='/docs/intro']");
    await expect(page).toHaveTitle(/Playwright Homepage/);
});