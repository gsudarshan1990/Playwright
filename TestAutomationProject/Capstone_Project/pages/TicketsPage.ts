import {Locator, Page} from '@playwright/test'

export class TicketsPage
{
     page:Page
     buyTickets: Locator
     name:Locator
     phonenumbertab:Locator
     phonenumber:Locator
     emailtab:Locator
     email:Locator
     ticketstab:Locator
     ticketQuantity:Locator
     tickets:Locator
     submit:Locator
     bookingConfirmationText:Locator

     constructor(page:Page)
     {
        this.page = page
        this.buyTickets = this.page.getByRole('button', {'name':'Buy Tickets'}).nth(1)
        this.name = this.page.getByRole('textbox', {'name':'Name'})
        this.phonenumbertab = this.page.getByRole('tab', {'name':'Fill out your phone number'})
        this.phonenumber = this.page.getByRole('textbox', {'name':'Phone Number'})
        this.emailtab = this.page.getByRole('tab', {'name':'Fill out your email id'})
        this.email = this.page.getByRole('textbox', {'name':'Email Id'})
        this.ticketstab = this.page.getByRole('tab', {'name':'Tickets'})
        this.ticketQuantity = this.page.getByRole('combobox', {'name':'Quanity'})
        this.submit = this.page.getByRole('button', {'name':'Submit'})
        this.bookingConfirmationText = this.page.getByText('Thank You!')
        
     }

     async clickBuyTickets()
     {
        await this.buyTickets.click()
     }

     async fillDetailsForTickets(name:string,phonenumber:string,emailid:string, quantityNumber:string)
     {
        await this.name.fill(name)
        await this.phonenumbertab.click()
        await this.phonenumber.fill(phonenumber)
        await this.emailtab.click()
        await this.email.fill(emailid)
        await this.ticketstab.click()
        await this.ticketQuantity.click()
        this.tickets = this.page.getByRole('option').nth(parseInt(quantityNumber))
        await this.tickets.click()
        await this.submit.click()
     }

     getBookingConfirmation():Locator
     {
        return this.bookingConfirmationText
     }

}