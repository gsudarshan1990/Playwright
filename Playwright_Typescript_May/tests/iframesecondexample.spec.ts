import {test,expect} from '@playwright/test'

test('iframes', async ({page})=>{

    await page.goto('https://ui.vision/demo/webtest/frames/',{'waitUntil':'domcontentloaded'})

    const frame2 =page.frameLocator('[src="frame_2.html"]')

    await frame2.locator('[name="mytext2"]').fill('Filling the second frame')

    
    const frame3 =page.frameLocator('[src="frame_3.html"]')
    
    await frame3.locator('[name="mytext3"]').fill('Filling the third frame')

    const outerhandle = await frame3.locator('iframe').elementHandle()

    const innerframe = await outerhandle?.contentFrame()


    await innerframe?.getByRole('button',{'name':'Next'}).click()

    const text = innerframe?.getByRole('textbox',{'name':'Enter a short text'})

    text?.scrollIntoViewIfNeeded()

    await text?.fill('This is the short text')

    await page.waitForTimeout(3000)
    
    const frame4 =page.frameLocator('[src="frame_4.html"]')
    
    await frame4.locator('[name="mytext4"]').fill('Filling the fourth frame')

})