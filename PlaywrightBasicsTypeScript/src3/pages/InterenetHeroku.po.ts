import { Page, Locator} from '@playwright/test';

export class LoginPage
{
        readonly page: Page;
        readonly username: Locator;
        readonly password: Locator;
        readonly loginbutton: Locator;

        constructor(page: Page)
        {
            this.page = page;
            this.username = page.locator('#username');
            this.password = page.locator('#password');
            this.loginbutton = page.getByRole('button', {name: ' Login'});
        }

        async navigate()
        {
            await this.page.goto('https://the-internet.herokuapp.com/login');
            await this.page.waitForLoadState('load');
        }

        async login(name:string, pass: string)
        {
            await this.username.fill(name);
            await this.password.fill(pass);
            await this.loginbutton.click();
        }

}