import {test,expect} from '@playwright/test'

test('validate 403', async ({request})=>{

    const respData = await request.delete('https://restful-booker.herokuapp.com/booking/1',{
        headers:{
            'Content-Type': 'application/json'
        }
    })

    console.log(respData.status())

    const respbody = await respData.text()
    console.log(respbody)

    expect(respData.status()).toBe(403)
})