import {test,expect} from '@playwright/test'

test.describe('Grouping tests', ()=>{

    test.beforeEach(async ({page})=>{

        await page.goto('https://example.com/')
    })

    test('Assert title',async ({page})=>{

        expect(await page.title()).toContain('Example Domain')
    })

    test('Assert tag',async ({page})=>{

        expect(await page.textContent('h1')).toContain('Example Domain')
    })
})