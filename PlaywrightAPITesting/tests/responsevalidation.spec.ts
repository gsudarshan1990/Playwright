import {test, expect} from '@playwright/test'

test('Response Validation', async ({request})=>{

    const respData = await request.post('https://lkmdemoaut.accenture.com/AccenSportzRestApi/addNewUser',{
        headers:{
            'Content-Type': 'application/json'
        },

        data:{
                "address": "Hyderabad",
                "age": 32,
                "dateofBirth": "2001-01-18",
                "emailId": "rakeshrao@gmail.com",
                "firstName": "Rakesh",
                "gender": "Male",
                "lastName": "Rao",
                "password": "pass12345",
                "phoneNo": 9988776655,
                "weight": 62,
                "zipcode": 500006
        }
    })

    const respjson = await respData.json()
    const userIDv = respjson.userID

    expect(respjson).toHaveProperty('message','Registration Successful')
    expect(respjson).toHaveProperty('userID',userIDv)

})