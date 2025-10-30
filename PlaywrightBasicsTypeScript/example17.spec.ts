import {test, expect} from '@playwright/test';

test('search products on the sauce labs', async({page})=>{
    await page.goto('https://www.saucedemo.com/');
    await page.getByPlaceholder('Username').fill('standard_user');
    await page.getByPlaceholder('Password').fill('secret_sauce');
    await page.getByRole('button', {name:'Login'}).click();

    const products = page.locator('.inventory_item_name');
    console.log(products.count);
    for(let i=0;i<products.count;i++)
    {
        console.log(page.locator('.inventory_item_name').nth(i+1));
    }
    await expect(products).toHaveCount(6);
    await expect(products.filter({'hasText': 'Backpack'})).toHaveCount(1);

});






