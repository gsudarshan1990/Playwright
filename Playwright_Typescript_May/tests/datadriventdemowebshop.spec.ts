import {test,expect} from '@playwright/test'
import usersdata from '../testdata/DemowebshopLoginData.json'

test('Login to the demo workshop',async ({page})=>{

    for(const info of usersdata)
    {
        await page.goto('https://demowebshop.tricentis.com/login')
        await page.locator('#Email').fill(info.username)
        await page.locator('#Password').fill(info.password)
        await page.getByRole('button',{'name':'Log in'}).click()
        expect (page.getByText('Welcome to our store')).toBeVisible()

    }
})