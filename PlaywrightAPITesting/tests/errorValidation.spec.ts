import {test,expect} from '@playwright/test'

test('Error 404', async  ({request})=>{

    const bookingID = 1047983212341234123
    const respData = await request.get(`https://restful-booker.herokuapp.com/booking/${bookingID}`)
    console.log(respData.status())
      
    expect(respData.status()).toBe(404)
    expect(respData.ok).toBeTruthy()

})