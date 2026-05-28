import {test,expect} from '@playwright/test'

test('Validate Post Request for Activities', async ({request})=>{

    const  respData = await request.post('https://fakerestapi.azurewebsites.net/api/v1/Activities',{
        headers:{
            'accept': 'text/plain',
            'Content-Type': 'application/json'
        },
        data:{
            "id": 31,
            "title": "Activity 31",
            "dueDate": "2026-05-28T13:53:41.007Z",
            "completed": true
        }
    })

    console.log(await respData.json())

})