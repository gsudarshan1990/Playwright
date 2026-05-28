import {test,expect} from '@playwright/test'

test('Validate Delete Request',async  ({request})=>{

    const respData = await request.delete('https://jsonplaceholder.typicode.com/posts/1')

    expect(respData.status()).toBe(200)

})