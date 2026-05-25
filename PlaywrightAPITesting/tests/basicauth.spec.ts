import {test,expect} from '@playwright/test'

test('Basic Authentication', async ({playwright})=>{

    const apicontext = await playwright.request.newContext({
        httpCredentials:{
            username:'user',
            password:'passwd'
        }
    })

    const respdata = await apicontext.get('https://httpbin.org/basic-auth/user/passwd')
    console.log(await respdata.json())
    expect(respdata.status()).toBe(200)
    expect(respdata.ok()).toBeTruthy()

})