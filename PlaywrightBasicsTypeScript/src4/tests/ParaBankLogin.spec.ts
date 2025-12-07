import { test, expect} from '@playwright/test';
import { ParaBankLoginPage } from '../pages/ParaBankLoginpage.po';
import { AccountsOverview } from '../pages/AccountsOverviewPage.po';

let parabankloginpage : ParaBankLoginPage
let accountoverview : AccountsOverview

test.beforeEach(async({page})=>{
        const parabankloginpage = new ParaBankLoginPage(page);
        await parabankloginpage.navigate();
        await page.waitForSelector("input[name='username']");
        await parabankloginpage.BankLogin('mark_test_2025_009','suresh08');
        await page.waitForLoadState('load');

});

test('Login to the bank account', async({page})=>{
        await expect(page).toHaveURL('https://parabank.parasoft.com/parabank/overview.htm'); 
        await page.waitForSelector('#showOverview h1');
        const accountoverview =new AccountsOverview(page);
        accountoverview.verifyLoaded();
});

test('Navigate to pages after Login',async({page})=>{
        await page.waitForSelector('#showOverview');
        await expect(page).toHaveTitle("ParaBank | Accounts Overview");
        const accountoverview =new AccountsOverview(page);
        accountoverview.navigateToHomePage();
        await page.waitForSelector("#rightPanel>span.services");
        await expect(page).toHaveURL('https://parabank.parasoft.com/parabank/index.htm'); 
        await page.waitForLoadState('load');
        accountoverview.navigateToAbout();
        await page.waitForSelector('#rightPanel>h1');
        await expect(page).toHaveURL('https://parabank.parasoft.com/parabank/about.htm'); 
        await page.waitForLoadState('load');
        accountoverview.navigateToContact();
        await page.waitForSelector('#rightPanel>h1');
        await expect(page).toHaveURL('https://parabank.parasoft.com/parabank/contact.htm');
        await page.waitForLoadState('load')
        await page.waitForTimeout(2000);
});

test.only('Navigate to Open New Account Page',async({page})=>{
        accountoverview = new AccountsOverview(page);
        await accountoverview.navigateToNewAccount();
        await page.waitForSelector('#rightPanel>div>#openAccountForm>form>select#type');
        await accountoverview.selectAccountType();
        await page.waitForTimeout(5000);
});