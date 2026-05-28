import {test,expect} from '@playwright/test'

test('Validate Put Request',async  ({request})=>{

    const respData = await request.put('https://fakerestapi.azurewebsites.net/api/v1/Activities/22',{
        headers:{
            'accept': 'text/plain',
            'Content-Type': 'application/json'
        },
        data:{
            "id": 22,
            "title": "using put to update from the playwright typescript program",
            "dueDate": "2026-05-28T14:04:32.713Z",
            "completed": false
        }
    })

    expect(respData.status()).toBe(200)
    expect(respData.ok()).toBeTruthy()
    console.log(await respData.json())

})