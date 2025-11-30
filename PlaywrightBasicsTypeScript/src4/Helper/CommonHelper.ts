import {Page, Locator} from '@playwright/test';
import { ParaBankLoginPage } from '../pages/ParaBankLoginpage.po';

export async function ParaBankEnterDetails(page: Page, locator1: Locator, value: string)
{
    await locator1.fill(value);
}

export async function ParaBankClick(locator1: Locator)
{
    await locator1.click();
}

export async function ParaBankEnterRegisterDetails(locator2: Locator, value: string)
{
    await locator2.fill(value);
}

export async function ParaBankRegisterClick(locator3:Locator)
{
    await locator3.scrollIntoViewIfNeeded();
    await locator3.click();
}