import {test,expect} from '@playwright/test'

test('Delete User Details', async ({request})=>{

    const respdata = await request.delete('https://lkmdemoaut.accenture.com/AccenSportzRestApi/deleteUser',{
        headers:{
            'Content-Type': 'application/json'
        },
        data:{
             "userID": 312308 

        }
    })

    expect(respdata.status()).toBe(200)

})