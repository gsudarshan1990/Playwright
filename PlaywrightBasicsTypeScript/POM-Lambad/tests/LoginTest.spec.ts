import {test,expect} from '@playwright/test';
import { HomePage} from '../pages/HomePage.po';
import { LoginPage } from '../pages/LoginPage.po';


test('Navigate to Login Page',async({page})=>{
    const homepage = new HomePage(page);
    await homepage.navigateTo();
    await homepage.clickToLoginPage();
    await page.waitForSelector(`#content`);
    await expect(page).toHaveTitle('Account Login');
});

test('Login to the applicaiton',async({page})=>{
    const homepage = new HomePage(page);
    await homepage.navigateTo();
    await homepage.clickToLoginPage();
    await page.waitForSelector(`#content`);
    const loginpage = new LoginPage(page);
    await loginpage.loginToApplication('lambdatestnew@yopmail.com','Lambda123');
    await page.waitForSelector('#content');
    await expect(page).toHaveTitle('My Account');
});

test('Invalid Login to the applicaiton', async({page})=>{
    const homepage = new HomePage(page);
    await homepage.navigateTo();
    await homepage.clickToLoginPage();
    await page.waitForSelector(`#content`);
    const loginpage = new LoginPage(page);
    await loginpage.loginToApplication('lambdtestnew@yopmail.com','Lambda123');
    await expect(page.getByText(' Warning: No match for E-Mail Address and/or Password.')).toBeVisible();
});