import {test,expect} from '@playwright/test'

test('Put Request', async ({request})=>{

    const respdata = await request.put('https://lkmdemoaut.accenture.com/AccenSportzRestApi/updateUserDataWithPut',{
        headers:{
            'Content-Type': 'application/json'
        },

       data:{
         "address": "Hyderabad",
                "age": 25,
                "dateofBirth": "2026-04-16",
                "emailId": "rakesh1990@gmail.com",
                "firstName": "Rakesh",
                "gender": "Male",
                "lastName": "Kumar",
                "password": "pass12345",
                "phoneNo": 9988776654,
                "userID":312300,
                "weight": 62,
                "zipcode": 500045
        }
       })

       const respjson = await respdata.json()
       expect(respdata.status()).toBe(200)
       console.log(respjson)
})

