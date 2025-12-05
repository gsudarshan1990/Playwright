import { Page, Locator} from '@playwright/test';
import { expect } from '@playwright/test';

export class AccountsOverview{
    readonly page: Page;
    readonly heading: Locator;
    readonly table: Locator;

    constructor(page:Page)
    {
        this.page = page;
        this.heading = page.locator('#showOverview h1');
        this.table = page.locator('#accountTable');
    }

    async verifyLoaded()
    {
       await expect(this.heading).toHaveText('Accounts Overview');
    }

    async getAccountNumber(): Promise<string[]>
    {
       const accountnumbers: string[] = [];
       await this.page.waitForTimeout(4000);
       const rows : Locator = this.table.locator('tbody tr td a');
       console.log(await rows.first().textContent());
       console.log(await rows.nth(1).textContent());
       return accountnumbers;
        
    }
}
