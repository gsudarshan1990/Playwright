import {test, expect} from '@playwright/test';
import { SauceDemoLoginPage } from '../pages/SauceDemoLoginPage.po';

test('test saucedemo login', async({page})=>{
    const saucedemologinobj = new SauceDemoLoginPage(page);
    await saucedemologinobj.goto();
    await saucedemologinobj.saucedemologin('standard_user','secret_sauce'); 
    await page.waitForTimeout(5000);
    await expect(page).toHaveURL(/inventory.html/);
    await expect(page.getByText('Products')).toBeVisible();
});
