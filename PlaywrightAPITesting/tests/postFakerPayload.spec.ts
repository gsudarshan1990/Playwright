import {test,expect} from '@playwright/test'
import {faker} from '@faker-js/faker'

test('Post using the Payload from faker', async  ({request})=>{

    const payload = {
    "firstname" : faker.person.firstName(),
    "lastname" : faker.person.lastName(),
    "totalprice" : faker.number.int({
        min:100,
        max:10000
    }),
    "depositpaid" : faker.datatype.boolean(),
    "bookingdates" : {
        "checkin" : "2018-01-01",
        "checkout" : "2019-01-01"
    },
    "additionalneeds" : faker.food.dish()
}

    console.log(payload)

    const respData = await request.post('https://restful-booker.herokuapp.com/booking',{
        headers:{
            'Content-Type': 'application/json'
        },
        data: payload

    })

    expect(respData.status()).toBe(200)

    console.log(await respData.json())
})