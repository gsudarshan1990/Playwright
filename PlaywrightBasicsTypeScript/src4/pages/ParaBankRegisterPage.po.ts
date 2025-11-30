import { Page, Locator} from '@playwright/test';
import { ParaBankEnterRegisterDetails, ParaBankRegisterClick } from '../Helper/CommonHelper';

export class ParaBankRegisterPage
{
    readonly page: Page;
    readonly URL : string;
    readonly FirstName : Locator;
    readonly LastName : Locator;
    readonly Address : Locator;
    readonly City: Locator;
    readonly State : Locator;
    readonly ZipCode: Locator;
    readonly PhoneNumber: Locator;
    readonly SSN: Locator;
    readonly UserName: Locator;
    readonly Passwrod: Locator;
    readonly ConfirmPassword : Locator;
    readonly Register : Locator;

    constructor(page:Page)
    {
        this.page = page;
        this.URL = 'https://parabank.parasoft.com/parabank/register.htm';
        this.FirstName = page.locator("input[id='customer.firstName']");
        this.LastName = page.locator("input[id='customer.lastName']");
        this.Address = page.locator("input[id='customer.address.street']");
        this.City = page.locator("input[id='customer.address.city']");
        this.State = page.locator("input[id='customer.address.state']");
        this.ZipCode = page.locator("input[id='customer.address.zipCode']");
        this.PhoneNumber = page.locator("input[id='customer.phoneNumber']");
        this.SSN = page.locator("input[id='customer.ssn']");
        this.UserName = page.locator("input[id='customer.username']");
        this.Passwrod = page.locator("input[id='customer.password']");
        this.ConfirmPassword = page.locator("input[id='repeatedPassword']");
        this.Register = page.getByRole('button', {name:'REGISTER'});
    }

    async navigate()
    {
        await this.page.goto(this.URL);
        await this.page.waitForLoadState('load');
    }

    async  BankRegisterPageDetails(pfirstname:string, plastname:string, paddres:string, pcity:string, pstate:string, pzipcode:string, pphonenumber:string, pssn: string, pusername:string, ppasswrod:string)
    {
        await ParaBankEnterRegisterDetails(this.FirstName,pfirstname);
        await ParaBankEnterRegisterDetails(this.LastName,plastname);
        await ParaBankEnterRegisterDetails(this.Address, paddres);
        await ParaBankEnterRegisterDetails(this.City, pcity);
        await ParaBankEnterRegisterDetails(this.State, pstate);
        await ParaBankEnterRegisterDetails(this.ZipCode, pzipcode);
        await ParaBankEnterRegisterDetails(this.PhoneNumber, pphonenumber);
        await ParaBankEnterRegisterDetails(this.SSN, pssn);
        await ParaBankEnterRegisterDetails(this.UserName, pusername);
        await ParaBankEnterRegisterDetails(this.Passwrod,ppasswrod);
        await ParaBankEnterRegisterDetails(this.ConfirmPassword,ppasswrod);
    }

    async RegsiterClick()
    {
        await ParaBankRegisterClick(this.Register);
    }
}