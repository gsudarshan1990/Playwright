import {test,expect} from '@playwright/test'

test('API chaining',async  ({request})=>{

    const authresponse = await request.post('https://restful-booker.herokuapp.com/auth', {
        headers:{
            'Content-Type': 'application/json'
        },
        data:
        {
             "username" : "admin",
                "password" : "password123"
        }
    })

    const authbody = await authresponse.json()
    const token = authbody.token
   
    const respData = await request.post('https://restful-booker.herokuapp.com/booking',{
        headers:{
            'Content-Type': 'application/json'
        },
        data:
        {
            "firstname" : "Rajesh",
            "lastname" : "Brown",
            "totalprice" : 190,
            "depositpaid" : true,
            "bookingdates" : {
                "checkin" : "2018-01-01",
                "checkout" : "2019-01-01"
            },
            "additionalneeds" : "super bowls"
        }
    })

    const respjson = await respData.json()
    const bookingID = respjson.bookingid

    const respDataGet = await request.get(`https://restful-booker.herokuapp.com/booking/${bookingID}`)
     expect(respDataGet.status()).toBe(200)

    const respDatPut = await request.put(`https://restful-booker.herokuapp.com/booking/${bookingID}`,{
        headers:{
            'Content-Type': 'application/json',
            'Accept': 'application/json',
            'Cookie': `token=${token}`
        },
        data:{
             "firstname" : "Suresh",
            "lastname" : "Brown",
            "totalprice" : 111,
            "depositpaid" : true,
            "bookingdates" : {
                "checkin" : "2018-01-01",
                "checkout" : "2019-01-01"
    },
    "additionalneeds" : "Breakfast"
        }
    })

    expect(respDatPut.status()).toBe(200)

    const respDataDelete = await request.delete(`https://restful-booker.herokuapp.com/booking/${bookingID}`,{
        headers:{
            'Content-Type': 'application/json',
            'Cookie': `token=${token}`

        }
    })

    expect(respDataDelete.status()).toBe(201)
    expect(respDataDelete.ok).toBeTruthy()
})