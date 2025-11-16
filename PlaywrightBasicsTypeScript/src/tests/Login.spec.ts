import {test, expect} from '@playwright/test';
import { LoginPage } from '../pages/LoginPage.po';


test('User login', async({page})=>{
    const login = new LoginPage(page);
    await login.goto();
    await login.loginpage('customer@practicesoftwaretesting.com', 'welcome01');
    await login.page.waitForTimeout(5000);
    await expect(page.getByRole('heading',{name:'My account'})).toBeVisible();
});

test('userlogin with wrong credentials', async({page})=>{
    const loginpage = new LoginPage(page);
    await loginpage.goto();
    await loginpage.loginWithInvalidCredentials('customer@gmail.com','welcome01');
    await loginpage.page.waitForTimeout(5000);
    await expect(page.getByText('Invalid email or password')).toBeVisible();

});