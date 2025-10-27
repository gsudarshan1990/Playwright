import {test,expect} from '@playwright/test';


test('check page url',async({page})=>{
    await page.goto('https://playwright.dev/');
    await page.getByRole('link',{name:'Docs'}).click();
    await page.waitForTimeout(2000);
    await expect(page).toHaveURL('https://playwright.dev/docs/intro');

});