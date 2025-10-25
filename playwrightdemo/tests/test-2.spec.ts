import { test, expect } from '@playwright/test';

test('test', async ({ page }) => {
  await page.goto('https://www.yahoo.com/');
  await page.getByRole('link', { name: 'Finance' }).click();
  await page.getByRole('textbox', { name: 'Search query' }).click();
  await page.getByRole('textbox', { name: 'Search query' }).fill('');
  await page.getByRole('textbox', { name: 'Search query' }).click();
  await page.getByRole('textbox', { name: 'Search query' }).fill('bank of america');
  await page.getByRole('button', { name: 'Search', exact: true }).click();
});