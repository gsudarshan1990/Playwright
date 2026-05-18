 import {Given, When, Then} from '@cucumber/cucumber'
 import {expect, chromium } from '@playwright/test'
 
 Given('user  is on the sauce demo page', async function () {
           // Write code here that turns the phrase above into concrete actions
           this.MyBrowser = await chromium.launch({headless:false})
           this.context = await this.MyBrowser.newContext()
           this.page = await this.context.newPage()
           await this.page.goto('https://www.saucedemo.com/')
         });
       
   
       
         When('User enters the username and password',async  function () {
           // Write code here that turns the phrase above into concrete actions
           await this.page.getByRole('textbox',{'name':'Username'}).fill('standard_user')
           await this.page.getByRole('textbox',{'name':'Password'}).fill('secret_sauce')
           await this.page.getByRole('button',{'name':'Login'}).click()
         });
       
  
         Then('User lands on the homepage',async function () {
           // Write code here that turns the phrase above into concrete actions
            expect(await this.page.url()).toBe('https://www.saucedemo.com/inventory.html')
            expect(await this.page.getByText('Products')).toBeVisible()
            this.page.close()
         });