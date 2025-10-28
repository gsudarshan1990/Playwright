import {test, expect } from '@playwright/test';

test('invalid login error', async({page}) =>{
    await page.goto('https://demoqa.com/login');
    await page.getByPlaceholder('UserName').fill('wrong_user');
    await page.getByPlaceholder('Password').fill('wrong_pass');
    await page.getByRole('button', {name:'Login'}).click();
    await page.waitForTimeout(3000);
    await expect(page.getByText('Invalid username or password!')).toBeVisible();

});