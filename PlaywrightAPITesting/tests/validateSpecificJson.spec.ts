import {test,expect} from '@playwright/test'


test('Validate spec json', async ({request})=>{

    const bookingID = 104
    const respData = await request.get(`https://restful-booker.herokuapp.com/booking/${bookingID}`)

    const respJson = await respData.json()    

    
    expect(respJson.firstname).toBe('John')
    expect(respJson.additionalneeds).toBe('Breakfast')
    

})