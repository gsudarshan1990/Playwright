import {test,expect} from '@playwright/test'

test('Passing Json Payload using the Variable',async  ({request})=>{
    
    const dataPayload = {
    "firstname" : "Rajesh",
    "lastname" : "Brown",
    "totalprice" : 111,
    "depositpaid" : true,
    "bookingdates" : {
        "checkin" : "2026-12-01",
        "checkout" : "2026-12-04"
    },
    "additionalneeds" : "Breakfast"
}

    const respData = await request.post('https://restful-booker.herokuapp.com/booking',{
        headers:{
            'Content-Type': 'application/json'
        },
        data:dataPayload
    })

    expect(respData.status()).toBe(200)
    console.log(await respData.json())
})