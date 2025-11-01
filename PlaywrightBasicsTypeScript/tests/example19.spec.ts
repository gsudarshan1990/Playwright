import {test, expect } from '@playwright/test';

test('Add product to the cart and verify ',async({page})=>{
    await page.goto('https://practicesoftwaretesting.com/');
    await page.locator('//a[@href="/auth/login"]').click();
    await page.waitForTimeout(1000);
    await page.getByPlaceholder('Your email').fill('customer@practicesoftwaretesting.com');
    await page.getByPlaceholder('Your password').fill('welcome01');
    await page.getByRole('button',{name:'Login'}).click();
    await page.waitForTimeout(2000);
    await page.getByRole('link',{name:'Home'}).click();
    await page.waitForSelector('//h5[contains(text(),"Hammer")]');
    const products = page.locator('//h5[contains(text(),"Hammer")]').nth(1);
    await products.scrollIntoViewIfNeeded();
    await products.click();
    await page.locator('#btn-add-to-cart').click();
    await page.waitForTimeout(3000);
    await page.locator('//a[@href="/checkout"]').click();
    await page.waitForTimeout(8000);
    const product = page.locator('.ng-star-inserted.horizontal.ng-star-inserted>div>aw-wizard-step>app-cart>div>table>tbody>tr>td>span').nth(0);
    const value = await product.innerText();
    const trimmedValue = value.trim();
    expect(trimmedValue).toEqual('Hammer');



});