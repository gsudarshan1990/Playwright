import {test,expect} from '@playwright/test'

test('Get All books', async ({request})=>{

    const respData = await request.get('https://demoqa.com/BookStore/v1/Books', {
        headers:{
            'accept': 'application/json'
        }
    })

    expect(respData.status()).toBe(200)

    const respbody = await respData.json()

    console.log(respbody)
    const books =respbody.books

    expect(Array.isArray(books)).toBe(true)

    const book = books[0]

    expect(book).toHaveProperty('title')
    expect(book).toHaveProperty('author')
    expect(book).not.toHaveProperty('id')
    expect(book).not.toHaveProperty('price')
    expect(book).not.toHaveProperty('avialable')

})