import {test,expect} from '@playwright/test'
import usersdata from '../testdata/SauceDemoLoginData.json'

test('Login to Sauce Demo with Data driven', async({page})=>{

 for(const datavalues of usersdata)
 {
    await page.goto("https://www.saucedemo.com/")
    await page.getByPlaceholder('Username').fill(datavalues.username)
    await page.getByRole('textbox',{'name':'Password'}).fill(datavalues.password)
    await page.getByRole('button').click()
    await page.getByText('Swag Labs').waitFor({'state':'visible'})
    expect (page.url()).toBe('https://www.saucedemo.com/inventory.html')
}


})