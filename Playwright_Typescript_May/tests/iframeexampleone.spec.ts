import {test,expect} from '@playwright/test'

test('iframe examples', async ({page})=>{

    await page.goto('https://vinothqaacademy.com/iframe/',{'waitUntil':'domcontentloaded'})

    const frame1 = page.frameLocator("iframe[name='employeetable']")

    expect(frame1.getByText('Project Details')).toBeVisible()

    await frame1.getByRole('textbox',{'name':'Name',exact:true}).fill('Ramesh')

    await frame1.getByRole('textbox',{'name':'Role'}).fill('QA')

    const frame2 = page.frameLocator("iframe[name='popuppage']")

    expect(frame2.getByRole('heading',{'name':'Alert and PopUp'})).toBeVisible()

})