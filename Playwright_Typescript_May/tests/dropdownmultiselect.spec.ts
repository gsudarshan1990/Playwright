import {test,expect} from '@playwright/test'

test('Dropdown', async ({page})=>{

    await page.goto('https://vinothqaacademy.com/drop-down/', {waitUntil:'domcontentloaded'})

    await page.locator('#FromAccount').scrollIntoViewIfNeeded()

    const AccountDropDown =  page.locator('#FromAccount')

    await AccountDropDown.selectOption('8400001 Bal - $3,881.62')

    await page.waitForTimeout(2000)

    await AccountDropDown.selectOption({'value':'Salary'})

    await page.waitForTimeout(2000) 

    await AccountDropDown.selectOption({'label':'8400045 Bal - $8,758.78'})

    await page.waitForTimeout(2000)

    await AccountDropDown.selectOption({'index':2})

    await page.waitForTimeout(2000)
})

test.only('Mult Select', async ({page})=>{

    await page.goto('https://vinothqaacademy.com/drop-down/', {waitUntil:'domcontentloaded'})

    const multiselect  = page.locator("select[name='programming']")

    await multiselect.scrollIntoViewIfNeeded()

    await multiselect.selectOption(["PHP","Ruby","Java"])

    await page.waitForTimeout(2000)

    const content = await page.locator("select[name='programming'] option").allTextContents()

    console.log("All Content", content)

    console.log("Content length",  content.length)

    console.log("===Printing Selected Option===")

    const selectedOption = await page.locator("select[name='programming'] option:checked").all()
    console.log("Selected Option",selectedOption.length)

    

})