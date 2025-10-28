import {test,expect} from '@playwright/test';

test('click get started using link', async({page})=>{
    await page.goto('https://playwright.dev/');
    await page.getByRole('link',{name:'Get started'}).click();
    await page.waitForTimeout(5000);
    await expect(page).toHaveURL(/.*docs\/intro/);
    await page.close();
    
});