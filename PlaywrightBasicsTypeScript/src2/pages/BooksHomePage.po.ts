import {Page, Locator} from '@playwright/test';

export class HomePage
{
    readonly page: Page;
    readonly loginbutton : Locator;
    readonly url = 'https://demoqa.com/books';

    constructor(page:Page)
    {
        this.page = page;
        this.loginbutton = page.locator('#login');
    }

    async navigate()
    {
        this.page.goto(this.url);
    }

    async clicklogin()
    {
        this.loginbutton.click();
    }
}