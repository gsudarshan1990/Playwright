import {test, expect} from '@playwright/test'

test.describe('Login to the sauce demo',()=>{

    test.beforeEach(async ({page})=>{
        await page.goto('https://www.saucedemo.com/')

    })

    test('Login first user', async ({page})=>{

        await page.getByPlaceholder('Username').fill('standard_user')
        await page.getByRole('textbox',{'name':'Password'}).fill('secret_sauce')
        await page.getByRole('button').click()
        expect (page.url()).toBe('https://www.saucedemo.com/inventory.html')
        expect (page.getByText('Swag Labs')).toBeVisible()
    })

    test('Failed Login',async  ({page})=>{

        await page.getByPlaceholder('Username').fill('locked_out_user')
        await page.getByRole('textbox',{'name':'Password'}).fill('secret_sauce')
        await page.getByRole('button').click()
        expect (page.getByText('Epic sadface: Sorry, this user has been locked out.')).toBeVisible()
    })
})


test.describe('Grouping tests',()=>{

    test('Runs while calling the group', ()=>{
        console.log("Running via group command")
        //npx playwright test -g "Grouping tests" --project=chromium
    })
})