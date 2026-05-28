import {test,expect,APIRequestContext} from '@playwright/test'


let apiContext:any
let bearertoken:any
let orderID:any
test.describe.serial("Add New Book", ()=>{

    test.beforeAll(async ({playwright})=>{

        apiContext = await playwright.request.newContext({
            baseURL:'https://simple-books-api.click'
        })
        const uniqueemail = `raj${Date.now()}@example.com`
        const respData = await apiContext.post('/api-clients/',{
            data:{
                "clientName": "PostmanTraining", 
                "clientEmail": uniqueemail
            }
        })

        const responsebody = await respData.json()
        bearertoken = responsebody.accessToken?.trim()
        console.log(bearertoken)
        await apiContext.dispose()
    })


    test('Create a new book order', async ({playwright})=>{

        apiContext = await playwright.request.newContext({
            baseURL:'https://simple-books-api.click',
            
        })

        const orderrespData = await apiContext.post('/orders',{
            headers:{
                'Content-Type': 'application/json',
                'Authorization':`Bearer ${bearertoken}`
            },
            data:{
                bookId:1,
                customerName: "Rajesh"
            }          
        })

        const respbody =await orderrespData.json()
        console.log(respbody)
        orderID = respbody.orderId
        await apiContext.dispose()
        
    })


    test('Delete a book order',async ({playwright})=>{

        apiContext = await playwright.request.newContext({
            baseURL:'Https://simple-books-api.click'
        })

        console.log(orderID)
        
        const respData = await apiContext.delete(`/orders/${orderID}`,{
            headers:{
                'Content-Type': 'application/json',
                'Authorization':`Bearer ${bearertoken}`
            }
        })

        
        expect(respData.status()).toBe(204)
        
    })
        

})