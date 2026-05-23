import {test,expect} from '@playwright/test'

test('Post Request', async  ({request})=>{

    const respdata = await request.post('https://restful-booker.herokuapp.com/booking',{
        headers:{
            'Content-Type': 'application/json'
        },
        data:{
            "firstname" : "Rajesh",
    "lastname" : "Brown",
    "totalprice" : 130,
    "depositpaid" : true,
    "bookingdates" : {
        "checkin" : "2026-12-01",
        "checkout" : "2026-12-04"
    },
    "additionalneeds" : "Breakfast"
        }
    })

    const respjson = await respdata.json()
    expect(respdata.status()).toBe(200)
    console.log(respjson)
})