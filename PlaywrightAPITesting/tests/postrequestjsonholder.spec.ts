import {test,expect} from '@playwright/test'


test('Post Request',async  ({request})=>{

    const response = await request.post('https://jsonplaceholder.typicode.com/posts', {
        data:{
            userId: 1,
            id: 101,
            title: 'Playwright Practice',
            body: 'This is a test post used for the playwright practice'

        }
    })

    expect(response.status()).toBe(201)
    console.log(await response.json())
})