import {test,expect} from '@playwright/test';
import { ParaBankRegisterPage } from '../pages/ParaBankRegisterPage.po';

let parabankregisterpage : ParaBankRegisterPage;

test('Enter Registration Details', async({page})=>{
    const parabankregisterpage = new ParaBankRegisterPage(page);
    await parabankregisterpage.navigate();
    await page.waitForTimeout(3000);
    await parabankregisterpage.BankRegisterPageDetails('Mark','Tester','road no:56','dayton','ohio','35333','987654321','111-22-3333','mark_test_001','rahul');
    await page.waitForTimeout(3000);
    await parabankregisterpage.RegsiterClick();
});