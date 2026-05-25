import {test,expect} from '@playwright/test'

test('Get Details from Pet Store API', async ({request})=>{

    const respData = await request.get('https://petstore.swagger.io/v2/pet/findByStatus?status=pending',{
        headers:{
            'accept': 'application/json'
        }
    })
    expect(respData.status()).toBe(200)
    console.log(await respData.json())

})