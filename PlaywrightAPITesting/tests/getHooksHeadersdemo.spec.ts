import {test,expect,request} from '@playwright/test'

let requestContext : any
test.beforeAll(async  ()=>{

    requestContext = await request.newContext({
        'baseURL':'https://restful-booker.herokuapp.com',
        extraHTTPHeaders:{
            Accept :'application/json'
        }
    })
})

test('Get Demo with before all hooks and headers', async ()=>{

    const respdata = await requestContext.get('/booking')
    const respjson = await respdata.json()
    console.log(respjson)

})