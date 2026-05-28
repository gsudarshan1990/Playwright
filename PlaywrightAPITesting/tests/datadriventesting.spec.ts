import {test,expect} from '@playwright/test'
import bookingdata from '../testdata/bookingdata.json'

test.describe('Data driven testing',()=>{
    for(const [index,data] of bookingdata.entries())
    {
        test(`for the test with ${index}+1`,async  ({request})=>{

            const respData = await request.post('https://restful-booker.herokuapp.com/booking', {
                headers:{
                    'Content-Type': 'application/json'
                },
                data:
                {
                    "firstname" : data.firstname,
                    "lastname" : data.lastname,
                    "totalprice" : data.totalprice,
                    "depositpaid" : data.depositpaid,
                    "bookingdates" : {
                        "checkin" : data.bookingdates.checkin,
                        "checkout" : data.bookingdates.checkout
                    },
                    "additionalneeds" : data.additionalneeds
                }
            })

            const respjson = await respData.json()
            expect(respData.status()).toBe(200)
            expect(respData.ok).toBeTruthy()

            expect(respjson.booking.firstname).toBe(data.firstname)
            expect(respjson.booking.lastname).toBe(data.lastname)
        })
    }


})