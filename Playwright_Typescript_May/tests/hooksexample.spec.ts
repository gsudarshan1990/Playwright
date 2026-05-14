import {test,expect} from '@playwright/test'

test.beforeEach(async ({page})=>{

    await page.goto("https://www.saucedemo.com/")
    await page.getByPlaceholder('Username').fill('standard_user')
    await page.getByPlaceholder('Password').fill('secret_sauce')
    await page.getByRole('button').click()
    
})

test('Verify Header',async ({page})=>{

    await expect(page.locator(".header_label")).toBeVisible();
    await page.waitForTimeout(2000)
})

test('Verify Inventory', async ({page})=>{

    await expect(page.getByText('Products')).toBeVisible()
    const products = page.locator('.inventory_item_name')
    console.log("Total Products",await products.count())
    await page.waitForTimeout(2000)

})

test.afterEach(async ({page})=>{
    await page.getByRole('button',{name:'Open Menu'}).click()
    await page.getByRole('link',{name:'Logout'}).click()
})