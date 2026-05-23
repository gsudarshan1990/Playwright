import {test,expect} from '@playwright/test'

test('Get Players', async ({request})=>{

    const respdata = await request.get('https://lkmdemoaut.accenture.com/AccenSportzRestApi/swagger-ui.html#/player-registration/getUserDetails',{
        headers:{
            'Content-Type':'application/json'
        }
    })

    expect(respdata.status()).toBe(200)
})