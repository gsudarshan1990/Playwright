import {Page} from '@playwright/test';

export class LoginPage
{
    readonly page: Page;
    readonly url = 'https://practicesoftwaretesting.com/auth/login';

    constructor(page:Page)
    {
        this.page = page;
    }

    async goto()
    {
        this.page.goto(this.url);
    }

    async loginpage(email:string, password : string)
    {
        await this.page.getByPlaceholder('Your email').fill(email);
        await this.page.getByPlaceholder('Your password').fill(password);
        await this.page.getByRole('button', {name:'Login'}).click();
    }
    
}