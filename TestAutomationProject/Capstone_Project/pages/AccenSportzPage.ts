import {Locator, Page} from '@playwright/test'
class AccenSportzPage
{
    page: Page
    playerregistrationlink : Locator
    bookticketslink: Locator
    constructor(page: Page)
    {
        this.page = page;
        this.playerregistrationlink = page.getByRole('link', {'name':'Player Registration'})
        this.bookticketslink = page.getByRole('link', {'name':'Book Tickets'})

    }

    async navigate(url:string)
    {
        this.page.goto(url)
    }

    async clickPlayerRegistration()
    {
        await this.playerregistrationlink.click()
    }

    async clickBookTickets()
    {
        await this.bookticketslink.click()
    }
}

export = AccenSportzPage;

