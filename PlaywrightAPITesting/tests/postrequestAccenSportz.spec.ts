import { test,expect} from '@playwright/test'


test('Post Details',async  ({request})=>{

    const respdata = await request.post('https://lkmdemoaut.accenture.com/AccenSportzRestApi/addNewUser',{
        headers:{
            'Content-Type': 'application/json'
        },
        data:{
                "address": "Hyderabad",
                "age": 25,
                "dateofBirth": "2026-04-16",
                "emailId": "suresh1990@gmail.com",
                "firstName": "Suresh",
                "gender": "Male",
                "lastName": "Kumar",
                "password": "pass12345",
                "phoneNo": 9988776654,
                "weight": 62,
                "zipcode": 500045
            }
        }
    )

    const respjson = await respdata.json()
    expect(respdata.status()).toBe(200)
    console.log(respjson)

})