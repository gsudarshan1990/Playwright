import {test, expect} from '@playwright/test'

test('Windows Pop Up',async  ({page})=>{

    await page.goto('https://testautomationpractice.blogspot.com/',{'waitUntil':'domcontentloaded'})

    const popupbutton = page.getByRole('button',{'name':'Popup Windows'})

    popupbutton.scrollIntoViewIfNeeded()

    const popupPromise = page.waitForEvent('popup')
    await popupbutton.click()

    const popup = await popupPromise

    await popup.waitForLoadState('domcontentloaded')

    const allpages = page.context().pages()

    for(let singlePage of allpages)
    {
        console.log("======")
        console.log(await singlePage.title())

        console.log(singlePage.url())

        console.log(await singlePage.locator('h1').textContent())

    }

})