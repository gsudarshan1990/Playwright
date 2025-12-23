import {expect,test} from '@playwright/test';
import { LoginPage } from '../pages/LoginPage.po';

test('Login to the page', async({page})=>{
    const loginpage = new LoginPage(page);
    await loginpage.navigate();
    await loginpage.login('applitoolsautomation@yopmail.com',"Test@123");
    await expect(page).toHaveURL('https://talent500.com/onboarding/resume/');
});