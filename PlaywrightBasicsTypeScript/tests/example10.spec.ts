import {test, expect } from '@playwright/test';

test('Open Community Page using browser',async({page}) => {
     await page.goto('https://playwright.dev/');
     await page.waitForTimeout(2000);
     await page.getByRole('link', {name:'Community'}).click();
     await expect(page).toHaveURL('https://playwright.dev/community/welcome');
     await page.waitForTimeout(2000);
});