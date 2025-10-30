import {test, expect} from '@playwright/test';

test('check the first product on the homepage', async({page})=>{
    page.goto('https://www.demoblaze.com/');

    const firstproduct = page.locator('.card-title a').first();

    const product_name = await firstproduct.innerText();
    console.log(product_name);

    const secondproduct = page.locator('.card-title a').nth(1);
    const second_product_name = await secondproduct.innerText();
    console.log(second_product_name);
    await page.waitForTimeout(2000);
    await expect(firstproduct).not.toBeEmpty();

});