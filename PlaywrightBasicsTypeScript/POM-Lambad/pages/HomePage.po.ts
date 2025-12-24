import { Page, Locator} from '@playwright/test';

export class HomePage
{
    readonly page: Page;
    readonly Myaccount : Locator;
    readonly LoginButton: Locator;

    constructor(page:Page)
    {
        this.page = page;
        this.Myaccount = page.locator(`div#widget-navbar-217834>ul>li:last-child`);
        this.LoginButton = page.getByRole('link',{name:'Login'});
        
    }

    async navigateTo()
    {
        this.page.goto('https://ecommerce-playground.lambdatest.io/');
    }

    async clickToLoginPage()
    {
        await this.Myaccount.click();
        await this.LoginButton.click();
    }
}