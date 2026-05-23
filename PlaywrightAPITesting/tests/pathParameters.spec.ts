import {test,expect} from '@playwright/test'

test('Path Parameter', async ({request})=>{

    const BookingID = 104
    console.log(`https://restful-booker.herokuapp.com/booking/${BookingID}`)

    const respdata = await request.get(`https://restful-booker.herokuapp.com/booking/${BookingID}`)
    expect(respdata.status()).toBe(200)
    console.log(await respdata.json())

})