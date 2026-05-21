import {test,expect} from '@playwright/test'

test('Get Registered',async ({page})=>{

    await page.goto('https://lkmdemoaut.accenture.com/TestMeApp/fetchcat.htm')
    expect(await page.title()).toBe('Home')
    await page.locator('[href="RegisterUser.htm"]').click()
    await page.getByRole('textbox',{'name':'User Name'}).fill('TestSudar178')
    await page.getByRole('textbox',{'name':'First Name'}).fill('Sudarshan')
    await page.getByRole('textbox',{'name':'Last Name'}).fill('Govind')
    await page.locator('#password').fill('secret_sauce')
    await page.getByRole('textbox', {'name':'Confirm Password'}).fill('secret_sauce')
    await page.locator('[value="Male"]').check()
    await page.getByRole('textbox',{'name':'E -Mail'}).fill('ramesh@gmail.com')
    await page.getByRole('textbox',{'name':'Mobile Number'}).fill('0893738930')
    await page.getByRole('textbox',{'name':'DOB'}).fill('08/04/1989')
    await page.locator('#address').fill('plot no:30,ram street,bhoiguda,Hyderabad')
    await page.locator('#securityQuestion').selectOption('411011')
    await page.getByRole('textbox',{'name':'Answer'}).fill('Green')
    await page.getByRole('button',{'name':'Register'}).click()  
    await page.waitForTimeout(2000)
    await page.getByText(' User Registered Succesfully!!! Please login').isVisible()
    })


