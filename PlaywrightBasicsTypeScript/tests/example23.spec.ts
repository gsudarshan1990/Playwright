import { test, expect} from '@playwright/test';

test.beforeEach(async({page})=>{
        await page.goto('https://practicesoftwaretesting.com/');
        await page.waitForLoadState();
});

test('Basic locator example ', async({page})=>{
    const products = page.locator('.card-title');
    await expect(products).toHaveCount(8);
});

test('print second product', async({page})=>{
    await page.waitForSelector('.card-title');
    const secondProduct = page.locator('.card-title').nth(1);
    await page.waitForTimeout(5000);
    expect (secondProduct).toBeVisible();
    const secondProductName = await secondProduct.innerText();
    console.log('Second Product', secondProductName);

});


test('filter products by text', async({page})=>{
    await page.waitForSelector('.card-title');
    const hammer =  page.locator('.card-title',{hasText:'Hammer'}).nth(2);
    await page.waitForTimeout(5000);
    await expect(hammer).toBeVisible();
});

test.only('Add Bolt Cutters to the Cart', async({page})=>{
    await page.waitForSelector('.card');
    const boltCutters = page.locator('.card',{hasText:'Bolt Cutters'});
    await page.waitForTimeout(2000);
    await boltCutters.click();

});
