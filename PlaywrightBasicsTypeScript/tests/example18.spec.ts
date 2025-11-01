import {test, expect } from '@playwright/test';

test('Check item added to the cart', async({page})=> {
    await page.goto('https://www.saucedemo.com/');
    await page.getByPlaceholder('Username').fill('standard_user');
    await page.getByPlaceholder('Password').fill('secret_sauce');
    await page.getByRole('button', {name: 'Login'}).click();
    await page.waitForTimeout(3000);
    await page.locator('#add-to-cart-sauce-labs-backpack').click();
    await page.waitForTimeout(2000);
    await page.locator('.shopping_cart_link').click();
    await page.waitForTimeout(2000);
    const products = page.locator('.inventory_item_name');
    await expect(products.filter({'hasText': 'Backpack'})).toHaveCount(1);
    await page.waitForTimeout(2000);
    await page.locator('#continue-shopping').click();
    await page.waitForTimeout(1000);
    await page.locator('#remove-sauce-labs-backpack').click();
    await page.waitForTimeout(1000);
    await page.locator('.shopping_cart_link').click();
    await page.waitForTimeout(2000);
    const products1 = page.locator('.inventory_item_name');
    await expect(products1.filter({'hasText': 'Backpack'})).toHaveCount(0);
    await page.close();
});