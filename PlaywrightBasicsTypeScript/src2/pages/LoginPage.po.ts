import { Page, Locator } from "@playwright/test";

export class LoginPage
{
    readonly page: Page;
    readonly username: Locator;
    readonly password : Locator;
    readonly loginbutton: Locator;
    readonly loginpagetext : Locator;

    constructor(page:Page)
    {
        this.page = page;
        this.username = page.getByPlaceholder('UserName');
        this.password = page.getByPlaceholder('Password');
        this.loginbutton = page.getByRole('button', {name:'Login'});
        this.loginpagetext = page.getByText('Login in Book Store');
    }

    async booksLogin(usernamecredential:string, passwordcredential:string)
    {
        await this.username.fill(usernamecredential);
        await this.password.fill(passwordcredential);
        await this.loginbutton.click();
    }
}