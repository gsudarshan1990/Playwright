import {test, expect } from '@playwright/test';

test('Add and subtract products to the cart',async({page})=>{
        await page.goto('https://practicesoftwaretesting.com/auth/login');
        await page.getByPlaceholder('Your email').fill('customer@practicesoftwaretesting.com');
        await page.getByPlaceholder('Your password').fill('welcome01');
        await page.getByRole('button', {name:'Login'}).click();
        await page.waitForTimeout(2000);
        await page.getByRole('link', {name:'Home'}).click();
        await page.waitForTimeout(2000);
        page.waitForSelector('//h5[contains(text(),"Hammer")]');
        const products = page.locator('//h5[contains(text(),"Hammer")]').nth(1);
        await products.scrollIntoViewIfNeeded();
        await products.click();
        await page.waitForTimeout(2000);
        await page.locator('#btn-add-to-cart').click();
        await page.locator('//div[@role="alert"]').click();
        await page.getByRole('link', {name:'Home'}).click();
        page.waitForSelector('//h5[contains(text(),"Slip Joint Pliers")]');
        const products1 = page.locator('//h5[contains(text(),"Slip Joint Pliers")]');
        await products1.scrollIntoViewIfNeeded();
        await products1.click();
        await page.waitForTimeout(2000);
        await page.locator('#btn-add-to-cart').click();
        await page.locator('//div[@role="alert"]').click();
        await page.waitForSelector('//a[@href="/checkout"]');
        await page.locator('//a[@href="/checkout"]').click();
        await page.waitForSelector('table tbody tr');
        const row = page.locator('table tbody tr', {hasText:'Slip Joint Pliers'});
        await row.locator('a').click();
        await page.waitForSelector("//div[@role='alert']");
        await page.locator('//div[@role="alert"]').click();
        const row1 = page.locator('table tbody tr', {hasText:'Slip Joint Pliers'});
        await expect(row1).toHaveCount(1);   
        await page.waitForTimeout(2000);

});

