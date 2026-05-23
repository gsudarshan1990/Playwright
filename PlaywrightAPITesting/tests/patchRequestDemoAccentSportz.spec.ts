import {test,expect} from '@playwright/test'

test('Patch Request', async ({request})=>{

    const respdata = await request.patch('https://lkmdemoaut.accenture.com/AccenSportzRestApi/updateUserDataWithPatch',{
        
        data:{
                "address": "Hyderabad",
                "age": 25,
                "dateofBirth": "2026-04-16",
                "emailId": "rakesh1990@gmail.com",
                "firstName": "Rakesh",
                "gender": "Male",
                "lastName": "Kumar",
                "password": "password12345",
                "phoneNo": 9988776654,
                "userID":312303,
                "weight": 80,
                "zipcode": 500045
        }
    })
    expect(respdata.status()).toBe(200)
    console.log(respdata.json())

})