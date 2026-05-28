import {test,expect} from '@playwright/test'

test("Validate APIs across differente browsers" , async ({browser})=>{

    const context = await browser.newContext()
    const request = context.request

    const reponse = await request.get('https://jsonplaceholder.typicode.com/posts/3')

    expect(reponse.status()).toBe(200)

    expect(reponse.ok()).toBeTruthy()

})