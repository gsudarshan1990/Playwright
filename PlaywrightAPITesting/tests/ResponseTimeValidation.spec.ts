import {test,expect} from '@playwright/test'

test('Response Time Validation', async ({request})=>{

    const startTime = Date.now()

    const respData =  await request.get('https://restful-booker.herokuapp.com/booking')

    const endTime = Date.now()

    const responseTime = endTime-startTime

    console.log(await respData.json())

    expect(responseTime).toBeLessThan(3000)
    expect(respData.status()).toBe(200)

})