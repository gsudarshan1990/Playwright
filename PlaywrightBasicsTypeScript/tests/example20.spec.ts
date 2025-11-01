/*

🎯 Goal:
Create a test on https://www.saucedemo.com/ that:

Logs in as standard_user

Adds two products to the cart

Opens the cart

Verifies that both products are listed

Clicks Checkout and verifies the checkout page is shown


*/

import {test, expect} from '@playwright/test';

test(' Add two products to the cart', async({page})=>{
    await page.goto('https://www.saucedemo.com/');
    await page.getByPlaceholder('Username').fill('standard_user');
    await page.getByPlaceholder('Password').fill('secret_sauce');
    await page.getByRole('button', {name:'Login'}).click();
    await page.waitForTimeout(1000);
    page.getByRole('button',{name:'Add to cart'}).first().click();
    page.getByRole('button',{name:'Add to cart'}).nth(1).click();
    await page.waitForTimeout(2000);
    await page.locator('.shopping_cart_link').click();
    await page.waitForTimeout(3000);
    const product_count = page.locator('.cart_item');
    const number = await product_count.count();
    expect(number).toBe(2);
    const checkout = page.getByRole('button',{name:'Checkout'})
    await checkout.scrollIntoViewIfNeeded();
    await checkout.click();
    await page.waitForTimeout(3000);
    await expect(page.getByText('Checkout: Your Information')).toBeVisible();
    await page.waitForTimeout(2000);
});