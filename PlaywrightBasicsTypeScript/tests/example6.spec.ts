import {test,expect} from '@playwright/test';

test('Fill and submit form', async({page}) => {
    await page.goto('https://demoqa.com/text-box');
    await page.fill('input[placeholder="Full Name"]','Rahul');
    await page.fill('input[placeholder="name@example.com"]','rahulsharma@gmail.com');
    //scroll down to the element before clicking 
    await page.locator('button[id="submit"]').scrollIntoViewIfNeeded(); 
    await page.waitForTimeout(3000);
    await page.click('button[id]');
    await page.close();
});