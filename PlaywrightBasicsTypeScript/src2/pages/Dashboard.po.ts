import {Page, Locator} from '@playwright/test';

export class Dashboard
{
    readonly page: Page;
    readonly usernamelabel : Locator;
    readonly logout : Locator;

    constructor(page:Page)
    {
        this.page = page;
        this.usernamelabel = page.locator('#userName-label');
        this.logout = page.locator('#submit');
    }

    async clickLogout()
    {
        this.logout.click();
    }
}