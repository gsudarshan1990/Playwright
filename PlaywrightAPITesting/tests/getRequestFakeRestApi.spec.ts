import {test,expect} from '@playwright/test'

test('Validate Get Request from Fake Rest API',async ({request})=>{

    const respData = await request.get('https://fakerestapi.azurewebsites.net/api/v1/Activities',{
        headers:{
            'accept': 'text/plain'

        }
    })

    const respjson = await respData.json()
    console.log(respjson)
    expect(respData.status()).toBe(200)
    expect(respData.ok()).toBeTruthy()

})