import {test, expect} from '@playwright/test'

test.describe('Error Screenshots', ()=>{

    test.beforeEach(async ({page})=>{

        await page.goto('https://www.saucedemo.com/')
        await page.getByPlaceholder('Username').fill('locked_out_user')
        await page.getByRole('textbox',{'name':'Password'}).fill('secret_sauce')
        await page.getByRole('button').click()

    })

    test('Page Screenshot',async ({page})=>{

        await page.screenshot({path:'../screenshots/screenshot_loginerror.png', fullPage:true})
        console.log('page screenshot completed')
    })

    test('Element Screenshot',async ({page})=>{

        await page.locator('[data-test="error"]').screenshot({path:'../screenshots/screenshot_elementerrormessage.png'})
        console.log('Element screenshot Completed')
    })
})