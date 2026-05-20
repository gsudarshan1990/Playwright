import {Given, When, Then } from '@cucumber/cucumber'
import {page} from '../support/hooks'
import {expect} from '@playwright/test'
       
Given('User on the Sauce demo page', async function () {
        // Write code here that turns the phrase above into concrete actions
        await page.goto('https://www.saucedemo.com/')
        });

    
        When('User logs with username and password', async function () {
        // Write code here that turns the phrase above into concrete actions
            await page.getByPlaceholder('Username').fill('standard_user')
            await page.getByRole('textbox',{'name':'Password'}).fill('secret_sauce')
            await page.getByRole('button').click()

        });
    

    
        Then('Should see the Inventory page', function () {
        // Write code here that turns the phrase above into concrete actions
            expect(page.url()).toContain('https://www.saucedemo.com/inventory.html')
            
            expect(page.getByText('Swag Labs')).toBeVisible()

            console.log("Hooks Executed")
        });