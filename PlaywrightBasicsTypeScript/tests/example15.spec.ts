import {test,expect} from '@playwright/test';

test('should list all the products from home page', async({page})=>{
    await page.goto('https://www.demoblaze.com/');

    const products = page.locator('.card-title a');

    await page.waitForTimeout(5000);
    const count = await products.count();

    console.log('Total Count '+count);

    for(let i=0;i<count;i++)
    {
        const product_name = await products.nth(i).innerText();
        console.log(product_name);
    }

});