import {test,expect} from '@playwright/test'

test('Status code validation', async   ({request})=>{

    const respdata = await request.get(' https://restful-booker.herokuapp.com/booking')
    console.log(await respdata.json())

    expect(respdata.status()).toBe(200)
    expect(respdata.ok()).toBeTruthy()

})