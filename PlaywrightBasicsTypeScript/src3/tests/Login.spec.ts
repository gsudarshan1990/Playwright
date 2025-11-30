import { test, expect } from '@playwright/test';
import { LoginPage } from '../pages/InterenetHeroku.po';
import { SecureAreaPage } from '../pages/SecurePage.po';

let loginpage = LoginPage;
let secureareapage = SecureAreaPage;

test('Login to the heroku application', async({page})=>{
    const loginpage = new LoginPage(page);
    await loginpage.navigate();
    await page.waitForTimeout(2000);
    await loginpage.login('tomsmith','SuperSecretPassword!');
    await page.waitForTimeout(2000);
    await page.waitForSelector('#flash');
    await expect(page).toHaveURL('https://the-internet.herokuapp.com/secure');
    const secureareapage = new SecureAreaPage(page);
    const text = await secureareapage.getSecureAreaMessage();
    await expect(text).toContain('Welcome to the Secure Area. When you are done click logout below.');
    
    
});