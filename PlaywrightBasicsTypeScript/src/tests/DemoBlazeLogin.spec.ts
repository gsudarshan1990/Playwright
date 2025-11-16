import {test, expect} from '@playwright/test';
import { DemoBlazeLoginPage } from '../pages/DemoBlazeLoginPage.po';

test('navigate to demo login page', async({page})=>{
    const demoblazeloginpage = new DemoBlazeLoginPage(page);
    await demoblazeloginpage.goto();
    await page.waitForTimeout(2000);;
    await demoblazeloginpage.navigateToLogin('mark_test_01','Test123!');
    await page.waitForTimeout(5000);
    await expect(demoblazeloginpage.loginuser).toBeVisible();
    
});