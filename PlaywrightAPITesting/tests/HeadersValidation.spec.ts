import {test, expect} from '@playwright/test'


test('Headers Validation', async ({request})=>{

    const respdata = await request.post('https://lkmdemoaut.accenture.com/AccenSportzRestApi/addNewUser',{
        headers:{
            'Content-Type': 'application/json'
        },
        data:{
                "address": "Kolkata",
                "age": 35,
                "dateofBirth": "1991-01-30",
                "emailId": "Rabindranathtagore@gmail.com",
                "firstName": "Rabindranath",
                "gender": "Male",
                "lastName": "Tagore",
                "password": "pass12345",
                "phoneNo": 9988776332,
                "weight": 62,
                "zipcode": 700006
        }
    })

    const respHeaders = respdata.headers()
    console.log(respHeaders)

    expect(respHeaders['content-type']).toContain('application/json')
    expect(respHeaders['content-encoding']).toContain('gzip')
    expect(respHeaders['transfer-encoding']).toContain('chunked')
    expect(respHeaders['server']).toContain('cloudflare')


})