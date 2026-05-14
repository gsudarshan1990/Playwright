import {test,expect} from '@playwright/test'

test('multiselect', async ({page})=>{

    await page.goto('https://testautomationpractice.blogspot.com/',{waitUntil:'domcontentloaded'})

    await page.locator('#colors').scrollIntoViewIfNeeded()

    const colorDropdown = page.locator('#colors')

    await colorDropdown.selectOption(["Red","Green","Yellow"])

    await page.waitForTimeout(2000)

    const content = page.locator("#colors option").allTextContents()

    const content1 = await content


    console.log("All Contents", content1)

    console.log("Lenght",content1.length)

    const selectedOptions = page.locator("#colors option:checked").all()

    console.log("Selected Options", (await selectedOptions).length)

})