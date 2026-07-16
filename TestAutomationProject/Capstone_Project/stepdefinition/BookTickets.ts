import {Given, When, Then, Before, After} from '@cucumber/cucumber'
import {expect, Browser,BrowserContext,Page, chromium } from '@playwright/test'
import AccenSportzPage from "../pages/AccenSportzPage"    
import {TicketsPage} from '../pages/TicketsPage'

let browser : Browser
let context : BrowserContext
let page: Page
let accensportz : AccenSportzPage
let ticketRegistration : TicketsPage

Before (async  ()=>{

    browser = await chromium.launch({headless:false})
    context = await browser.newContext()
    page = await context.newPage()
})


      Given('user is on the Accen SportsPage to book tickets {string}', async function (url:string) {
           // Write code here that turns the phrase above into concrete actions
            accensportz = new AccenSportzPage(page)
            await accensportz.navigate(url)      
         });
       
         When('user click the book tickets in the homepage', async function () {
           // Write code here that turns the phrase above into concrete actions
            await accensportz.clickBookTickets()
            ticketRegistration = new TicketsPage(page)
         });
       
       
         When('user tries to buy ticket by providing {string},{string},{string},{string}', {timeout:20000}, async function (name:string, phonenumber:string, email:string, quantity:string) {
           // Write code here that turns the phrase above into concrete actions
           await ticketRegistration.clickBuyTickets()
           await ticketRegistration.fillDetailsForTickets(name,phonenumber,email,quantity)
         });

       
         Then('user buys the ticket', async function () {
           // Write code here that turns the phrase above into concrete actions
           expect(ticketRegistration.getBookingConfirmation()).toBeVisible()
         });