import {Given, When, Then, Before, After} from '@cucumber/cucumber'
import {expect, Browser,BrowserContext,Page, chromium } from '@playwright/test'
import AccenSportzPage from "../pages/AccenSportzPage"    
import {PlayerRegistrationPage} from '../pages/PlayerRegistrationPage'

let browser : Browser
let context : BrowserContext
let page: Page
let accensportz : AccenSportzPage
let playerRegistration : PlayerRegistrationPage

Before (async  ()=>{

    browser = await chromium.launch({headless:false})
    context = await browser.newContext()
    page = await context.newPage()
})


          Given('user is on the Accen SportsPage {string}', async function (url:string) {
           // Write code here that turns the phrase above into concrete actions     
            
            accensportz = new AccenSportzPage(page)
            accensportz.navigate(url)
            accensportz.clickPlayerRegistration()
            playerRegistration = new PlayerRegistrationPage(page)
            
         })
       

       
         When('user clicks the register button', async function () {
           // Write code here that turns the phrase above into concrete actions
            accensportz.clickPlayerRegistration()
            playerRegistration = new PlayerRegistrationPage(page)
         });

          When('user enters the details like {string}, {string}, {string},{string}, {string},{string}, {string},{string}, {string}', {timeout:30000}, async function (firstname:string,lastname: string, dob:string, phone:string, gender:string, sport1:string, sport2:string, address:string, zipcode:string) {
           // Write code here that turns the phrase above into concrete actions
           await playerRegistration.fillDetailsWithParameters(firstname,lastname,dob,phone,gender,sport1,sport2,address,zipcode)
         });
         
       
         Then('user should be able to register',async  function () {
           // Write code here that turns the phrase above into concrete actions
           expect(playerRegistration.getRegistrationSuccess()).toBeVisible()
         });



