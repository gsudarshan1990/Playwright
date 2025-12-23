import {expect,test} from '@playwright/test';
import { LoginPage } from '../pages/LoginPage.po';
import { HomePage } from '../pages/HomePage.po';

test('Login to the page and then log out', async({page})=>{
    const loginpage = new LoginPage(page);
    await loginpage.navigate();
    await loginpage.login('applitoolsautomation@yopmail.com',"Test@123");
    await page.waitForLoadState('load');
    await page.waitForSelector(`a[href="/jobs/"]`);
    await expect(page).toHaveURL('https://talent500.com/onboarding/resume/');    
    const hompage = new HomePage(page);
    await hompage.logout();
    await expect(page).toHaveURL('https://talent500.com/auth/signin/');
});

