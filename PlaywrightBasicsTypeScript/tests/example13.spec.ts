import {test,expect} from '@playwright/test';

test ('Asserting the heading', async ({page})=>{
    await page.goto('https://example.com/');
    const heading = page.locator('h1');
    await expect(heading).toHaveText(/Example Domain/);
    await page.getByRole('link', {name:'Learn more'}).click();
    await page.waitForTimeout(2000);
    await expect(page).toHaveURL('https://www.iana.org/help/example-domains');
});