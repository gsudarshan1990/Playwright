import {test,expect} from '@playwright/test'

test('Verify Title', async ({page})=>{

    await page.goto('https://example.com/',{waitUntil:'load'})

    expect(page).toHaveTitle(/Example Domain/)

    const content = await page.textContent('h1')

    expect(content).toBe("Example Domain")
})