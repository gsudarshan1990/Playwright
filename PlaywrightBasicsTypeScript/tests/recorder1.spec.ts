import { test, expect } from '@playwright/test';

test('test_recorder', async ({ page }) => {
  await page.goto('https://demo.playwright.dev/todomvc/#/');
  await page.getByRole('textbox', { name: 'What needs to be done?' }).click();
  await page.getByRole('textbox', { name: 'What needs to be done?' }).fill('Buy Milk');
  await page.getByRole('textbox', { name: 'What needs to be done?' }).press('Enter');
  await expect(page.getByTestId('todo-title')).toContainText('Buy Milk');
});