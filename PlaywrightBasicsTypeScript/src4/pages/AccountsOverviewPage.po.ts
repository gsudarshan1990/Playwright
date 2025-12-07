import { Page, Locator} from '@playwright/test';
import { expect } from '@playwright/test';
import { ParaBankClick } from '../Helper/CommonHelper';

export class AccountsOverview{
    readonly page: Page;
    readonly heading: Locator;
    readonly table: Locator;
    readonly home: Locator;

    constructor(page:Page)
    {
        this.page = page;
        this.heading = page.locator('#showOverview h1');
        this.table = page.locator('#accountTable');
        this.home = page.locator("#headerPanel>ul[class='button']>li[class='home']");
    }

    async verifyLoaded()
    {
       await expect(this.heading).toHaveText('Accounts Overview');
    }

    async navigateToHomePage()
    {
        await ParaBankClick(this.home);
    }
}
