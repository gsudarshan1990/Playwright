import {test,expect} from '@playwright/test';

test('using role based locators', async({page})=>{
    await page.goto('https://demoqa.com/text-box');
    await page.getByRole('textbox', {name:'Full Name'}).fill("Ramesh");
    await page.locator('button[id="submit"]').scrollIntoViewIfNeeded();;
    await page.getByPlaceholder('name@example.com').fill("ramesh@demoqa.com");
    await page.getByPlaceholder('Current Address').fill("123 Main St, Cityville");
    await page.locator('//textarea[@id="permanentAddress"]').fill("456 Side St, Townsville");
    await page.getByRole('button', {name:'Submit'}).click();
    await page.waitForTimeout(5000);
    await page.close();
});

