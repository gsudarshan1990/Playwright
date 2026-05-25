import {test,expect} from '@playwright/test'

test('Put Request ', async ({request})=>{

    const repData = await request.put('https://petstore.swagger.io/v2/pet', {
        headers:{
            'accept': 'application/json',
            'Content-Type': 'application/json'
        },
        data:{
            id: 102,
            category: { id: 10, name: 'cats' },
            name: 'swatkat',
            photoUrls: [ 'string' ],
            tags: [ { id: 3, name: 'indoor stadium' } ],
            status: 'sold'
        }
    })

    expect(repData.status()).toBe(200)
    console.log(await repData.json())
})