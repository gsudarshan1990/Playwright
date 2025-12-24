import {Page,Locator} from '@playwright/test';

export class LoginPage
{
    readonly page:Page;
    readonly email:Locator;
    readonly password:Locator;
    readonly loginButton:Locator;

    constructor(page:Page)
    {
        this.page = page;
        this.email = page.getByPlaceholder('E-Mail Address');
        this.password = page.getByPlaceholder('Password');
        this.loginButton = page.getByRole('button',{name:'Login'});
    }

    async loginToApplication(email:string, password:string)
    {
        await this.email.fill(email);
        await this.password.fill(password);
        await this.loginButton.click();
    }
}