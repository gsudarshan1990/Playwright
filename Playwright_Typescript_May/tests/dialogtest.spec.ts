import {test,expect} from '@playwright/test'

test.beforeEach(async ({page})=>{

    page.goto('https://testautomationpractice.blogspot.com/',{'waitUntil':'domcontentloaded'})
})

test('Simple Alert', async ({page})=>{

    page.on('dialog', async (dialog)=>{

        expect(dialog.type()).toBe('alert')
        const message =  dialog.message()
        expect(message).toContain('I am an alert box!')
        await dialog.accept()

    })

    await page.getByRole('button',{'name':'Simple Alert'}).click()

})

test('Confirmation Alert Ok',async ({page})=>{

    page.on('dialog', async (dialog)=>{

        expect(dialog.type()).toBe('confirm')
        const message = dialog.message()
        expect(message).toContain('Press a button!')
        console.log(message)
        dialog.accept()
    })

    await page.getByRole('button',{'name':'Confirmation Alert'}).click()
    const promptMessage = await page.locator('#demo').textContent()
    expect(promptMessage).toContain('You pressed OK!')
})

test('Confirmation Alert Cancel',async ({page})=>{

    page.on('dialog', async (dialog)=>{

        expect(dialog.type()).toBe('confirm')
        const message = dialog.message()
        expect(message).toContain('Press a button!')
        console.log(message)
        dialog.dismiss()
    })

    await page.getByRole('button',{'name':'Confirmation Alert'}).click()
    const promptMessage = await page.locator('#demo').textContent()
    expect(promptMessage).toContain('You pressed Cancel!')
})

test('Prompt  Alert ok', async ({page})=>{

    page.on('dialog',async (dialog)=>{

        expect(dialog.type()).toBe('prompt')
        const message = dialog.message()
        expect(message).toContain('Please enter your name:')
        const defaultValue = dialog.defaultValue()
        expect(defaultValue).toContain('Harry Potter')
        dialog.accept("Rakesh")
    })

    await page.getByRole('button', {'name':'Prompt Alert'}).click()
    const promptMessage = await page.locator('#demo').textContent()
    expect(promptMessage).toContain('Hello Rakesh! How are you today?')
})

test('Prompt  Alert Cancel', async ({page})=>{

    page.on('dialog',async (dialog)=>{

        expect(dialog.type()).toBe('prompt')
        const message = dialog.message()
        expect(message).toContain('Please enter your name:')
        const defaultValue = dialog.defaultValue()
        expect(defaultValue).toContain('Harry Potter')
        dialog.dismiss()
    })

    await page.getByRole('button', {'name':'Prompt Alert'}).click()
    const promptMessage = await page.locator('#demo').textContent()
    expect(promptMessage).toContain('User cancelled the prompt.')
})