import {test, expect} from '@playwright/test'

test('Post Request for the Petstore', async ({request})=>{

    const respData = await request.post('https://petstore.swagger.io/v2/pet',{
        headers:{
            'accept': 'application/json',
            'Content-Type': 'application/json'
        },
        data:{
            "id": 103,
            "category": {
                "id": 10,
                "name": "Dog"
            },
            "name": "Scooby Doo",
            "photoUrls": [
                "string"
            ],
            "tags": [
                {
                "id": 3,
                "name": "Outdoor stadium"
                }
            ],
            "status": "pending",
                                    
        }
    })
    expect(respData.status()).toBe(200)
    console.log(await respData.json())

})