import {test, expect} from '@playwright/test'

test.beforeEach(async ({page})=>{

    await page.goto('https://testautomationpractice.blogspot.com/', {'waitUntil':'domcontentloaded'})
})

test('dragDrop',async ({page})=>{

    const src = page.locator('#draggable')
    src.scrollIntoViewIfNeeded()

    const dest = page.locator('#droppable')

    await src.dragTo(dest)

    await expect(page.getByText('Dropped!')).toBeVisible()
})

test('Mouse Houver',async ({page})=>{


    const pointme = page.locator('.dropbtn')
    await pointme.scrollIntoViewIfNeeded()

    await pointme.hover()

    await page.waitForTimeout(2000)

    const pointmelist = page.locator('.dropdown-content a')

    const mobile = pointmelist.first()
    await mobile.hover()
    
    await page.waitForTimeout(2000)


    const laptop = pointmelist.last()
    await laptop.hover()
    
    await page.waitForTimeout(1000)

})

test('double click', async ({page})=>{

    const doubleClick = page.getByRole('button', {'name':'Copy Text'})
    doubleClick.scrollIntoViewIfNeeded()
    await doubleClick.dblclick()
    const text = await page.locator('#field2').inputValue()
    expect(text).toContain('Hello World!')
})