import {Page, Locator} from '@playwright/test';

export class ParaBankLoginPage
{
    readonly page: Page;
    readonly username : Locator;
    readonly password : Locator;
    readonly LoginButton: Locator;

    constructor(page: Page)
    {
        this.page = page;
        this.username = page.locator("input[name='username']");
        this.password = page.locator("input[name='password']");
        this.LoginButton = page.getByRole('button', {name : 'LOG IN'});
    }

    async navigate()
    {
        await this.page.goto('https://parabank.parasoft.com/parabank/index.htm');
        await this.page.waitForLoadState('load');
    }

    async BankLogin(username : string, password : string)
    {
       
        await this.username.fill(username);
        await this.password.fill(password);
        await this.LoginButton.click();
    }
}