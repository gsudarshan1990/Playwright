import { test, expect} from '@playwright/test';
import { ParaBankLoginPage } from '../pages/ParaBankLoginpage.po';

let parabankloginpage : ParaBankLoginPage
test('Login to the bank account', async({page})=>{
        const parabankloginpage = new ParaBankLoginPage(page);
        await parabankloginpage.navigate();
        await page.waitForSelector("input[name='username']");
        await page.waitForTimeout(2000);
        await parabankloginpage.BankLogin('mark_test_001','rahul');
        await page.waitForTimeout(5000);
        await expect(page).toHaveURL('https://parabank.parasoft.com/parabank/overview.htm');

});