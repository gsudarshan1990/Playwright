import {test,expect} from '@playwright/test'

test('Get request with headers',async ({request})=>{

    const respdata = await request.get('https://restful-booker.herokuapp.com/booking',{
        headers:{
            Accept:'application/json'
        }
    })

    const respjson = await respdata.json()
    expect(respdata.status()).toBe(200)
    console.log(respjson)

})