import {Page, Locator} from '@playwright/test';

export class LoginPage
{
    readonly page: Page;
    readonly email: Locator;
    readonly password: Locator;
    readonly loginButton: Locator;

    constructor(page:Page)
    {
        this.page = page;
        this.email = page.getByPlaceholder('Email');
        this.password = page.getByPlaceholder('Password');
        this.loginButton = page.getByRole('button', {name:'Login'});
    }

    async navigate()
    {
        await this.page.goto('https://talent500.com/auth/signin/');
    }

    async login(userid : string, pass:string)
    {
        await this.email.fill(userid);
        await this.password.fill(pass);
        await this.loginButton.click();
    }
}