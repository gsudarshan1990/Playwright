import {test,expect} from '@playwright/test'

test('Navigate to Sauce Demo and Login and Logout', async({page})=>{

    await page.goto('https://www.saucedemo.com/',{waitUntil:'load'})

    await expect(page).toHaveURL('https://www.saucedemo.com/')

    await page.getByPlaceholder('Username').fill('standard_user')

    await page.getByRole('textbox',{name:'Password'}).fill('secret_sauce')

    await page.getByRole('button').click();

    await expect(page.getByText('Products')).toBeVisible();

    const dropdown = page.getByRole('combobox')

    await dropdown.selectOption('lohi')

    await page.getByText('Sauce Labs Backpack').click()

    await page.getByRole('button', {name:"Add to cart"})

    await page.getByRole('button',{name:'Open Menu'}).click()


    await page.getByRole('link',{name:'Logout'}).click()
})