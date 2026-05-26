import {Given, When, Then, Before} from '@cucumber/cucumber'
import {expect, Page, Browser, BrowserContext,chromium} from '@playwright/test'

let browser: Browser
let context:BrowserContext
let page:Page

Before(async ()=>{
    
    browser = await chromium.launch({headless:false})
    context = await browser.newContext()
    page = await context.newPage()
})
       
         Given('user on the {string}', async function (url:string) {
           // Write code here that turns the phrase above into concrete actions
            await page.goto(url)
         });

       
         When('Navigate to the login page', async function () {
           // Write code here that turns the phrase above into concrete actions
           await page.getByRole('link', {'name':'Log in'}).click()
         });
       

         When('user enters the username {string}', async function (username:string) {
           // Write code here that turns the phrase above into concrete actions
           await page.getByRole('textbox', {'name':'Email:'}).fill(username)
         });
  
       
         When('user enters the password {string}', async function (password:string) {
           // Write code here that turns the phrase above into concrete actions
          await page.getByRole('textbox',{'name':'Password:'}).fill(password)
         });
       
   
       
         Then('user logs in', async function () {
           // Write code here that turns the phrase above into concrete actions
           await page.getByRole('button',{'name':'Log in'}).click()
           expect(page.getByText('Welcome to our store')).toBeVisible()
         });