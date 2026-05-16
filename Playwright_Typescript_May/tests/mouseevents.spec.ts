import {test, expect} from '@playwright/test'

test.beforeEach(async ({page})=>{

    await page.goto('https://vinothqaacademy.com/mouse-event/')
})


test('double click', async ({page})=>{

    const doubleclickbutton =  page.getByRole('button',{'name':'Double Click Me'})
    await doubleclickbutton.dblclick()
    expect(await page.locator('#doubleStatus').innerText()).toContain('Double Click Detected ')
})

test('Right Click', async ({page})=>{

    const rightClick = page.getByRole('button',{'name':'Right Click Me'})
    rightClick.scrollIntoViewIfNeeded()
    await rightClick.click({'button':'right'})
    expect(await page.locator('#rightStatus').innerText()).toContain('Menu opened')
})

test('Drag and Drop', async ({page})=>{

    const src = page.locator('#dragItem')
    src.scrollIntoViewIfNeeded()
    const dest = page.locator('#dropZone')
    await src.dragTo(dest)
    expect(await page.locator('#dragStatus').innerText()).toContain('Dropped Successfully')

})

test('mouse hover',async ({page})=>{

    const HoverOnMeButton = page.locator('#tooltipTarget')
    HoverOnMeButton.scrollIntoViewIfNeeded()
    expect(await page.locator('#tooltipStatus').innerText()).toContain('Hover to see tooltip')
    await HoverOnMeButton.hover()
    expect(await page.locator('#tooltipStatus').innerText()).toContain('Tooltip Visible')

})