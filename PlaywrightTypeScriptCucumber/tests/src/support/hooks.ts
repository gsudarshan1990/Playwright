import {Browser, BrowserContext, Page, chromium} from'@playwright/test'
import { Before, BeforeAll,After} from '@cucumber/cucumber'


let browser:Browser
let context: BrowserContext
let page:Page

BeforeAll(async ()=>{

    browser = await chromium.launch({headless:false})

})

Before(async()=>{

    context = await browser.newContext()
    page = await context.newPage()
})

After(async ()=>{
    page.close()
    context.close()
    
})

export { page, context,browser}