import {test, expect} from '@playwright/test';

test('Test By Role', async({page})=>{
    await page.goto('https://practicesoftwaretesting.com/');
    await page.waitForLoadState();
    await page.getByRole('link',{name:'Sign in'}).click();
    await expect (page).toHaveURL(/login/);
    page.goto('https://practicesoftwaretesting.com/');
    await page.waitForLoadState();
    await page.getByText('Contact').click();
    expect (page).toHaveURL(/contact/) 
    await page.getByPlaceholder('Your first name *').fill('Mark');
    await page.getByPlaceholder('Your last name *').fill('Waugh');
    await page.getByLabel('email').fill('markwaugh@gmail.com');
    
});


