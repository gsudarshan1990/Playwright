import {test,expect} from '@playwright/test'

test('Get through query parameters',async ({request})=>{

    const respData = await request.get('https://jsonplaceholder.typicode.com/comments?users=2')
    expect(respData.status()).toBe(200)
    console.log(await respData.json())

})


test('Get through query parameters Demo second', async ({request})=>{

    const respData = await request.get('https://jsonplaceholder.typicode.com/comments',{
        params:{
           'postId':1
        }
    })
    expect(respData.status()).toBe(200)
    console.log(await respData.json())

})



test('Get Parameters Demo 3',async  ({request})=>{

    const respData = await request.get('https://restful-booker.herokuapp.com/booking',{
        params:{
           firstname:'Rajesh',
           lastname:'Brown'
        }
    })
    expect(respData.status()).toBe(200)
    console.log(await respData.json())

})

test('Get Parameters Demo 4 ',async ({request})=>{

    const respData= await request.get('https://restful-booker.herokuapp.com/booking?firstname=Rajesh&lastname=Brown')
    expect(respData.status()).toBe(200)
    console.log(await respData.json())
})