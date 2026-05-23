import {test, expect,request} from '@playwright/test'


let requestContext:any
test.beforeAll(async ()=>{

    requestContext = await request.newContext({
        'baseURL':'https://restful-booker.herokuapp.com/'
    })

})

test('Get Demo', async ({request})=>{

    const respdata = await request.get('https://restful-booker.herokuapp.com/booking')
    const respjson = await respdata.json()
    expect (respdata.status()).toBe(200)
    console.log(respjson)

})

test('Get Demo 2', async ()=>{

    const requestcontext = await request.newContext(
        {
            baseURL:'https://restful-booker.herokuapp.com'
        }
    )

    const respdata = await requestcontext.get('/booking')
    const respjson = await respdata.json()
    console.log(respjson)
})

test('Get demo 3', async  ()=>{

    const respdata = await requestContext.get('/booking')
    const respbody = await respdata.json()
    expect(respdata.status()).toBe(200)
    console.log(respbody)
})