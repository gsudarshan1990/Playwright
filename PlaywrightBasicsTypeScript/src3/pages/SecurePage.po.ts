import { Page, Locator } from "@playwright/test";

export class SecureAreaPage
{
    readonly page: Page;
    readonly successmessage : Locator;
    readonly secureAreaMessage : Locator;

    constructor(page: Page)
    {
        this.page = page;
        this.successmessage = page.locator('#flash');
        this.secureAreaMessage = page.locator('h4');
    }

    async getSuccessMessage() : Promise<string>{
        
        const text = await this.successmessage.innerText();
        return text.trim();
        
    }

    async getSecureAreaMessage() : Promise<string>{
        const securetext = await this.secureAreaMessage.innerText();
        return securetext.trim();
    }

}