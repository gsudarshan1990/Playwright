import {test, expect} from'@playwright/test';
import { OrangeHRMLogin } from '../pages/OrangeHRMLoginPage.po';


test('login to OrangeHRM', async({page})=>{
    const orangehrmlive = new OrangeHRMLogin(page);
    await orangehrmlive.navigateToOrangeHRMHomePage();
    await page.waitForLoadState('networkidle');
    await orangehrmlive.enterUsername('Admin');
    await page.waitForTimeout(2000);
    await orangehrmlive.enterPassword('admin123');
    await page.waitForTimeout(5000);
    await orangehrmlive.clickLogin();
    await page.waitForTimeout(5000);
    await expect(page.getByText('manda userDoe')).toBeVisible();

});