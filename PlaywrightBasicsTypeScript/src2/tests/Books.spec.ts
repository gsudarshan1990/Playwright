import {test,expect} from '@playwright/test';
import { HomePage} from '../pages/BooksHomePage.po';
import { LoginPage  } from '../pages/LoginPage.po';
import { Dashboard } from '../pages/Dashboard.po';

let homepage : HomePage;
let loginpage : LoginPage;
let dashboard : Dashboard;


test('Multipe Page POM demo', async({page})=>{
    const homepage = new HomePage(page);
    await homepage.navigate();
    await page.waitForTimeout(5000);
    await homepage.clicklogin();
    const loginpage = new LoginPage(page);
    await page.waitForTimeout(8000);
    await expect(loginpage.loginpagetext).toBeVisible();
    await loginpage.loginbutton.scrollIntoViewIfNeeded();
    await loginpage.booksLogin('gunjankaushik','Password@123');
    await page.waitForTimeout(5000);
    const dashboard = new Dashboard(page);
    expect (dashboard.usernamelabel).toBeVisible();
    await dashboard.clickLogout();
    await page.waitForTimeout(3000);
    await expect(page).toHaveURL(/login/)
})