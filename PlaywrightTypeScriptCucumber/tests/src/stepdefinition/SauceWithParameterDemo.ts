import {Given, When, Then, Before} from '@cucumber/cucumber'
import {test,expect,chromium,Page} from '@playwright/test'

let browser:any
let context:any
let page:Page
Before(async ()=>{

    browser = await chromium.launch({'headless':false})
    context = await browser.newContext()
    page = await context.newPage()
   

})

       
         Given('User Navigates to the url {string}', async function (url:string) {
           // Write code here that turns the phrase above into concrete actions
            await page.goto(url)
         });
       
   
       
         When('User enters the username {string}', async function (username:string) {
           // Write code here that turns the phrase above into concrete actions
            await page.getByPlaceholder('Username').fill(username)
         });
       

       
         When('User enters the password {string}', async function (password:string) {
           // Write code here that turns the phrase above into concrete actions
           await page.getByPlaceholder('Username').fill(password)
         });
       

       
         Then('user logins to the application',async  function () {
           // Write code here that turns the phrase above into concrete actions
           await page.getByRole('button').click()
           expect(page.getByText('Swag Labs')).toBeVisible()
         });