import { test, expect } from '@playwright/test';

test('test', async ({ page }) => {
  await page.goto('https://the-internet.herokuapp.com/add_remove_elements/');
  await page.getByRole('button', { name: 'Add Element' }).click();
  await page.getByRole('button', { name: 'Add Element' }).click();
  await expect(page.getByRole('button', { name: 'Delete' }).first()).toBeVisible();
  await page.getByRole('button', { name: 'Delete' }).nth(1).click();
  await page.waitForTimeout(2000);
});