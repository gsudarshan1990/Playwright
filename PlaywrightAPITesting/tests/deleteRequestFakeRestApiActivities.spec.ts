import {test,expect} from '@playwright/test'

test('Validate Delete API Request',async  ({request})=>{

    const respData = await request.delete('https://fakerestapi.azurewebsites.net/api/v1/Activities/22',{
        headers:{
            'accept': '*/*'
        }
    })

    expect(respData.status()).toBe(200)

})