import {test,expect} from '@playwright/test'

test('Navigate to the sauce demo', async({page})=>{

    await page.goto('https://www.saucedemo.com/',{waitUntil:'load'})

    await expect(page).toHaveURL('https://www.saucedemo.com/')

    await expect(page.getByText('Swag Labs')).toBeVisible();
})