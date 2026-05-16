import {test,expect} from '@playwright/test'


test('Demo qa iframes', async ({page})=>{

    await page.goto('https://demoqa.com/frames',{'waitUntil':'domcontentloaded'})

    const handle1 = await  page.locator('#frame1').elementHandle()

    const firstframe =await handle1?.contentFrame()

    expect(await firstframe?.locator('h1').innerText()).toContain('This is a sample page')

    const secondframe = page.frameLocator('#frame2')

    expect(await secondframe.locator('h1').innerText()).toContain('This is a sample page')

})