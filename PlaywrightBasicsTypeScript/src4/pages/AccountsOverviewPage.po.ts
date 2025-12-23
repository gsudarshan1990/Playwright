import { Page, Locator} from '@playwright/test';
import { expect } from '@playwright/test';
import { ParaBankClick } from '../Helper/CommonHelper';

export class AccountsOverview{
    readonly page: Page;
    readonly heading: Locator;
    readonly table: Locator;
    readonly home: Locator;
    readonly about : Locator;
    readonly contact: Locator;
    readonly opennewaccount : Locator;
    readonly accountType: Locator;
    readonly OpenNewAccountButton : Locator;

    constructor(page:Page)
    {
        this.page = page;
        this.heading = page.locator('#showOverview h1');
        this.table = page.locator('#accountTable');
        this.home = page.locator("#headerPanel>ul[class='button']>li[class='home']");
        this.about = page.locator("#headerPanel>ul[class='button']>li[class='aboutus']");
        this.contact = page.locator("#headerPanel>ul[class='button']>li[class='contact']");
        this.opennewaccount = page.locator('#bodyPanel>#leftPanel>ul>li>a',{hasText:'Open New Account'});
        this.accountType = page.locator('#type');
        this.OpenNewAccountButton = page.getByRole('button',{name:'OPEN NEW ACCOUNT'});
    }

    async verifyLoaded()
    {
       await expect(this.heading).toHaveText('Accounts Overview');
    }

    async navigateToHomePage()
    {
        await ParaBankClick(this.home);
    }

    async navigateToAbout()
    {
        await ParaBankClick(this.about);
    }

    async navigateToContact()
    {
        await ParaBankClick(this.contact);
    }

    async navigateToNewAccount()
    {
        await ParaBankClick(this.opennewaccount);
    }

    async selectAccountType()
    {
          this.accountType.selectOption('SAVINGS');
          await this.page.keyboard.press('Tab');
          await this.page.keyboard.press('Tab');
          await this.OpenNewAccountButton.click({force:true});
    }
}
