import {test,expect} from '@playwright/test'

test('Windows Pop Up Second Example', async ({page})=>{

    await page.goto('https://vinothqaacademy.com/multiple-windows/',{'waitUntil':'domcontentloaded'})

    const newWindowButton = page.getByRole('button',{'name':'New Browser Window'})

    const popupPromise = page.waitForEvent('popup')

    await newWindowButton.click()

    const popup = await popupPromise

    await popup.waitForLoadState('domcontentloaded')

    const allPages = page.context().pages()

    for(let singlepage of allPages)
    {
        console.log("==========")
        console.log(await singlepage.title())
        console.log(await singlepage.locator('h2').textContent())
    }

})