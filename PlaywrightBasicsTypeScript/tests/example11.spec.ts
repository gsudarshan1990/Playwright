import {test, expect} from '@playwright/test';

test('login flow of sauce demo app',async({page})=> {
    await page.goto('https://www.saucedemo.com/');
    await page.getByPlaceholder('Username').fill('standard_user');
    await page.getByPlaceholder('Password').fill('secret_sauce');
    await page.getByRole('button',{name:'Login'}).click();
    await page.waitForTimeout(3000);
    await expect(page).toHaveURL(/inventory/);
});