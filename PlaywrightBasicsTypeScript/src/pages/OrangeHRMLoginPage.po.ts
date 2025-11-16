import {Page, Locator} from '@playwright/test';

export class OrangeHRMLogin
{
    readonly page: Page;
    readonly url = 'https://opensource-demo.orangehrmlive.com/';
    readonly username : Locator;
    readonly password: Locator;
    readonly loginbutton: Locator;

    constructor(page:Page)
    {
        this.page = page;
        this.username = page.getByPlaceholder('Username');
        this.password = page.getByPlaceholder('Password');
        this.loginbutton = page.getByRole('button', {name:'Login'});
    }

    async navigateToOrangeHRMHomePage()
    {
        this.page.goto(this.url);
    }

    async enterUsername(username:string)
    {
        this.username.fill(username);
    }
    
      async enterPassword(password:string)
    {
        this.password.fill(password);
    }

    
    async clickLogin()
    {
        this.loginbutton.click();
    }

}