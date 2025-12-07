import { test, expect} from '@playwright/test';
import { ParaBankLoginPage } from '../pages/ParaBankLoginpage.po';
import { AccountsOverview } from '../pages/AccountsOverviewPage.po';

let parabankloginpage : ParaBankLoginPage
let accountoverview : AccountsOverview

test.beforeEach(async({page})=>{
        const parabankloginpage = new ParaBankLoginPage(page);
        await parabankloginpage.navigate();
        await page.waitForSelector("input[name='username']");
        await parabankloginpage.BankLogin('mark_test_2025_007','suresh08');
        await page.waitForLoadState('load');

});

test('Login to the bank account', async({page})=>{
        await expect(page).toHaveURL('https://parabank.parasoft.com/parabank/overview.htm'); 
        const accountoverview =new AccountsOverview(page);
        accountoverview.verifyLoaded();
});

test('Navigate to Home page after Login',async({page})=>{
        await page.waitForSelector('#showOverview');
        await expect(page).toHaveTitle("ParaBank | Accounts Overview");
        const accountoverview =new AccountsOverview(page);
        accountoverview.navigateToHomePage();
        await page.waitForSelector("#rightPanel>span.services");
        await expect(page).toHaveURL('https://parabank.parasoft.com/parabank/index.htm');       
});