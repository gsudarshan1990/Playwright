import {test, expect} from '@playwright/test';

test('search products on the sauce labs', async({page})=>{
    await page.goto('https://www.saucedemo.com/');
    await page.getByPlaceholder('Username').fill('standard_user');
    await page.getByPlaceholder('Password').fill('secret_sauce');
    await page.getByRole('button', {name:'Login'}).click();

    const products = page.locator('.inventory_item_name');
    const count = await products.count();
    await expect(products).toHaveCount(6);

    for(let i=0;i<count;i++)
    {
        const  product_name =await products.nth(i).innerText();
        console.log(product_name)
    }

    await expect(products.filter({'hasText': 'Backpack'})).toHaveCount(1);

});
