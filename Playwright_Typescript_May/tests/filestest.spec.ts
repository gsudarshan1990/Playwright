import { test, expect} from '@playwright/test'
import path from 'path';

test.beforeEach(async ({page})=>{

    await page.goto('https://testautomationpractice.blogspot.com/',{'waitUntil':'domcontentloaded'})
})


test('single file upload and deselect', async ({page})=>{

    const choosesingleFile = page.locator('#singleFileInput')

    choosesingleFile.scrollIntoViewIfNeeded()

    await choosesingleFile.setInputFiles('first.txt')

    const uploadfile = page.getByRole('button',{'name':'Upload Single File'})

    await uploadfile.click()

    const status = page.locator('#singleFileStatus')


    expect(await status.innerText()).toContain('Single file selected: first.txt, Size: 45 bytes, Type: text/plain')

    await page.waitForTimeout(2000)

    await choosesingleFile.setInputFiles([])

    await uploadfile.click()

    expect(await status.innerText()).toContain('No file selected.')

})

test('multiple files upload and deselect', async ({page})=>{

    const uploadmultiplefile = page.locator('#multipleFilesInput')

    uploadmultiplefile.scrollIntoViewIfNeeded()

    await uploadmultiplefile.setInputFiles([path.join('C:/Users/LENOVO/OneDrive/Desktop/Copilot Agent/playwright_practice/Playwright_Typescript_May/multiple.txt'),path.join('C:/Users/LENOVO/OneDrive/Desktop/Copilot Agent/playwright_practice/Playwright_Typescript_May/first.txt')])

    const uploadmultiplefiles   = page.getByRole('button',{'name':'Upload Multiple Files'})

    await uploadmultiplefiles.click()

    const fileuploadstatus = page.locator('#multipleFilesStatus')

    expect(await fileuploadstatus.innerText()).toContain('Multiple files selected:')

    await page.waitForTimeout(2000)

    await uploadmultiplefile.setInputFiles([])

    await uploadmultiplefiles.click()

    expect(await fileuploadstatus.innerText()).toContain('No files selected.')


})

