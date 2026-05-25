import {test,expect} from '@playwright/test'

test('Get using the path parameter',async  ({request})=>{
    
    const petId = 102

    const respData = await request.get(`https://petstore.swagger.io/v2/pet/${petId}`,{
        headers:{
            'accept': 'application/json'
        }
    })

    expect(respData.status()).toBe(200)
    console.log(await respData.json())
})

test('Get using path parameter Demo 2 ',async ({request})=>{

    const petID= 103

    const respData = await request.get('https://petstore.swagger.io/v2/pet/',{
        headers:{
            'accept': 'application/json'
        },
        params:{
            'petId':petID
        }
    })
    expect(respData.status()).toBe(200)
    console.log(await respData.json())

})