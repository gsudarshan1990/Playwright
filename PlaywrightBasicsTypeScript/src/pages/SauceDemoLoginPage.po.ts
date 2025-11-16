import {Locator, Page} from '@playwright/test';

export class SauceDemoLoginPage{
    readonly page: Page;
    readonly user_name: Locator;
    readonly pass_word: Locator;
    readonly login_button: Locator;
    readonly url ='https://www.saucedemo.com/';

    constructor(page:Page)
    {
        this.page = page;
        this.user_name = this.page.getByPlaceholder('Username');
        this.pass_word = this.page.getByPlaceholder('Password');
        this.login_button = this.page.getByRole('button', {name: 'Login'});   
    }

    async goto()
    {
        this.page.goto(this.url);
    }

    async saucedemologin(username:string, password:string)
    {
        this.user_name.fill(username);
        this.pass_word.fill(password);
        this.login_button.click();
    }
}