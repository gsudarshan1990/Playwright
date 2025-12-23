import { Page,Locator} from '@playwright/test';

export class HomePage{
    readonly page;
    readonly profile;
    readonly logoutButton;

    constructor(page:Page)
    {
        this.page = page;
        this.profile = page.getByText('John ').first();
        this.logoutButton = page.getByRole('button', {name:'Logout'});
        
    }

    async logout()
    {
        await this.profile.click();
        await this.logoutButton.click();
    }
}