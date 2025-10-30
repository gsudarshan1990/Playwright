import {test, expect} from '@playwright/test';

test('click a button on practice software testing', async({page})=>{
    await page.goto('https://practicesoftwaretesting.com/contact');
    await page.getByRole('link',{name:'Contact'}).click();
    await page.waitForTimeout(1000);
    await page.getByPlaceholder('Your first name *').fill('Rajesh');
    await page.getByPlaceholder('Your last name *').fill('Kumar');
    await page.getByPlaceholder('Your email *').fill('rajeshkumar@gmail.com');
    await page.waitForTimeout(2000);
});