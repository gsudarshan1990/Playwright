import { test, expect } from '@playwright/test';

test('test', async ({ page }) => {
  await page.goto('https://the-internet.herokuapp.com/inputs');
  await page.getByRole('spinbutton').click();
  await page.getByRole('spinbutton').fill('12345');
  await expect(page.getByRole('spinbutton')).toHaveValue('12345');
});