import {test, expect} from '@playwright/test'

test.beforeEach(async ({page})=>{

    await page.goto('https://the-internet.herokuapp.com/javascript_alerts', {'waitUntil':'domcontentloaded'})

})

test('Internet Heroku Simple Alert', async ({page})=>{

    page.on('dialog', async (dialog)=>{

        expect(dialog.type()).toBe('alert')
        const message = dialog.message()
        expect(message).toContain('I am a JS Alert')
        dialog.accept()
    })

    await page.getByRole('button',{'name':'Click for JS Alert'}).click()
    const resultmessage =  await page.locator('#result').textContent()
    expect(resultmessage).toContain('You successfully clicked an alert')
})



test('Internet Heroku Confirm Alert Ok', async ({page})=>{

    page.on('dialog', async (dialog)=>{

        expect(dialog.type()).toBe('confirm')
        const message = dialog.message()
        expect(message).toContain('I am a JS Confirm')
        dialog.accept()
    })


    await page.getByRole('button', {'name':'Click for JS Confirm'}).click()
    const result_message = await page.locator('#result').textContent()
    expect(result_message).toContain('You clicked: Ok')
})

test('Internet Heroku Confirm Alert Cance', async ({page})=>{

    page.on('dialog', async (dialog)=>{

        expect(dialog.type()).toBe('confirm')
        const message = dialog.message()
        dialog.dismiss()
    })


    await page.getByRole('button', {'name':'Click for JS Confirm'}).click()
    const result_message = await page.locator('#result').textContent()
    expect(result_message).toContain('You clicked: Cancel')
})

test('Internet Heroku Prompt Alert ok', async( {page})=>{

    page.on('dialog', async (dialog)=>{

        expect(dialog.type()).toBe('prompt')
        const message = dialog.message()
        expect(message).toContain('I am a JS prompt')
        dialog.accept('Rajesh')

    })

    await page.getByRole('button', {'name':'Click for JS Prompt'}).click()
    const result_message = await page.locator('#result').textContent()
    expect(result_message).toContain('You entered: Rajesh')

})


test('Internet Heroku Prompt Alert Empty', async( {page})=>{

    page.on('dialog', async (dialog)=>{

        expect(dialog.type()).toBe('prompt')
        dialog.accept()

    })

    await page.getByRole('button', {'name':'Click for JS Prompt'}).click()
    const result_message = await page.locator('#result').textContent()
    expect(result_message).toContain('You entered: ')

})


test('Internet Heroku Prompt Alert Cancel', async( {page})=>{

     page.on('dialog', async (dialog)=>{

        expect(dialog.type()).toBe('prompt')
        dialog.dismiss()

    })

    await page.getByRole('button', {'name':'Click for JS Prompt'}).click()
    const result_message = await page.locator('#result').textContent()
    expect(result_message).toContain('You entered: null')

})