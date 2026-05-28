import {test, expect} from '@playwright/test'


test('Validate Get Request', async ({request})=>{

    const respData = await request.get('https://jsonplaceholder.typicode.com/posts')


    console.log(await respData.json())
    expect(respData.status()).toBe(200)
    expect(respData.ok()).toBeTruthy()
    

    
    const respData1 = await request.get('https://jsonplaceholder.typicode.com/posts/1')
    expect(respData.status()).toBe(200)
    expect(respData.ok()).toBeTruthy()


    const respjson = await respData1.json()
    console.log(respjson)
    expect(respjson.id).toBe(1)
    

    
})

