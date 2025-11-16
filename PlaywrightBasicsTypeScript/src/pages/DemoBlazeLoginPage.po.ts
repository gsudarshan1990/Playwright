import {Page, Locator} from '@playwright/test';

export class DemoBlazeLoginPage
{
        readonly page: Page;
        readonly url ='https://www.demoblaze.com/';
        readonly login: Locator;
        readonly loginusername: Locator;
        readonly loginpassword: Locator;
        readonly loginbutton: Locator;
        readonly loginuser : Locator;

        constructor(page:Page)
        {
            this.page = page;
            this.login = page.locator("//a[contains(text(),'Log in')]");
            this.loginusername = page.locator('#loginusername');
            this.loginpassword = page.locator('#loginpassword');
            this.loginbutton = page.locator("//button[contains(text(),'Log in')]");
            this.loginuser = page.locator('#nameofuser');
        }

        async goto()
        {
            this.page.goto(this.url);
        }

        async navigateToLogin(username:string, password:string)
        {
            this.login.click();
            this.loginusername.fill(username);
            this.loginpassword.fill(password);
            this.loginbutton.click();

        }
}