import { test, expect} from '@playwright/test';
import { ParaBankLoginPage } from '../pages/ParaBankLoginpage.po';
import { AccountsOverview } from '../pages/AccountsOverviewPage.po';

let parabankloginpage : ParaBankLoginPage
let accountoverview : AccountsOverview
test('Login to the bank account', async({page})=>{
        const parabankloginpage = new ParaBankLoginPage(page);
        await parabankloginpage.navigate();
        await page.waitForSelector("input[name='username']");
        await parabankloginpage.BankLogin('mark_test_2025_004','suresh08');
        await page.waitForTimeout(2000);
        await expect(page).toHaveURL('https://parabank.parasoft.com/parabank/overview.htm'); 
        const accountoverview =new AccountsOverview(page);
        accountoverview.verifyLoaded();
});