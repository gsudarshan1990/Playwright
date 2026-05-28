import {test,expect} from '@playwright/test'

test('validate Put Request', async ({request})=>{

    const respData = await request.put('https://jsonplaceholder.typicode.com/posts/1',{
        data:{
            userId: 1,
            id: 101,
            title: 'Playwright Practice Updated',
            body: 'This is a test post used for the playwright practice updated'

        }
    })

    console.log(await respData.json())
})