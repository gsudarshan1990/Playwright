import {test, expect} from '@playwright/test'

test('Validate Get Request for ReqRes', async ({request})=>{

    const respData = await request.get('https://reqres.in/api/users')

    console.log(await respData.json())
    expect(respData.status()).toBe(200)
    expect(respData.ok()).toBeTruthy()


})