import {test, expect} from '@playwright/test'

test('Drop down', async ({page})=>{

    await page.goto('https://testautomationpractice.blogspot.com/')

    await page.locator('#country').scrollIntoViewIfNeeded()

    const countryDropdown = page.locator('#country')

    await countryDropdown.selectOption('India')

    await page.waitForTimeout(2000)

    await countryDropdown.selectOption({'value':'uk'})

    await page.waitForTimeout(2000)

    await countryDropdown.selectOption({'index':6})

    await page.waitForTimeout(2000)

    await countryDropdown.selectOption({'label':'Brazil'})

    await page.waitForTimeout(2000)


})