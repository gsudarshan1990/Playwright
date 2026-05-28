import {test,expect} from '@playwright/test'

test('Validate Get with Path Parameters', async ({request})=>{

    const respData =  await request.get('https://fakerestapi.azurewebsites.net/api/v1/Activities/22',{
        headers:{
            'accept': 'text/plain'
        }
    })

    expect(respData.status()).toBe(200)
    expect(respData.ok()).toBeTruthy()

    console.log(await respData.json())



})