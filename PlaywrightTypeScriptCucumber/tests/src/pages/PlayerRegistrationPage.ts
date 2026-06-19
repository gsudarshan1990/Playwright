import {Locator, Page} from '@playwright/test'

export class PlayerRegistrationPage
{
    page:Page
    firstName:Locator
    lastName:Locator
    dob:Locator
    phoneNumber:Locator
    emailAddress:Locator
    gender:Locator
    address:Locator
    zipcode:Locator
    accept:Locator
    age:Locator
    option:Locator
    sport:Locator
    basketball:Locator
    Hockey:Locator
    basketballCheckbox: Locator
    hockeyCheckbox: Locator
    agerange: Locator
    chooseFile :Locator
    acceptCheckbox: Locator
    submit:Locator
    email : string
    regirstationSuccessfulMessage:Locator

    constructor(page:Page)
    {
        this.page = page
        this.firstName = page.getByRole('textbox', { name: 'Firstname' })
        this.lastName = page.getByRole('textbox', { name: 'Lastname' })
        this.dob = page.getByRole('textbox', { name: 'Date of Birth' })
        this.phoneNumber = page.locator("#phonenumber")
        this.emailAddress = page.getByRole('textbox', { name: 'Enter your email' })
        this.age = page.locator('[name="selectage"]')
        this.sport = page.locator('#multisport')
        this.option = page.locator("div[role='listbox'] mat-option").nth(2)
        this.agerange = page.getByRole('heading', {'name':'h4'})
        this.chooseFile = page.locator('[type="file"]')
        this.address = page.getByRole('textbox', {'name':'Address'})
        this.zipcode = page.locator('[formcontrolname="zipcode"]')
        this.acceptCheckbox = page.getByRole('checkbox', {'name':'Accept Terms and Conditions'})
        this.submit = page.getByRole('button', {'name':'SUBMIT'})
        this.regirstationSuccessfulMessage = page.getByText('Registration Successfull !')
    }


    async fillDetailsWithParameters(firstname:string, lastname:string, dob:string, phone:string,genderValue:string, sport1Value:string, sport2Value:string,address:string,zipcode:string)
    {

        await this.firstName.fill(firstname)
        await this.lastName.fill(lastname)
        await this.dob.fill(dob)
        await this.phoneNumber.fill(phone) 
        this.email = firstname+lastname+Date.now()+'@mail.com'
        await this.emailAddress.fill(this.email)
        this.gender = this.page.getByRole('radio', {'name': genderValue, exact:true})
        await this.gender.click()
        await this.age.click({force:true})
        await this.option.waitFor({state:'visible',timeout:3000})
        await this.option.click({force:true})            
        await this.sport.waitFor({state:'visible',timeout:2000})
        await this.sport.dispatchEvent('click')
        this.Hockey = this.page.getByRole('option', {'name':sport1Value})
        this.basketball = this.page.getByRole('option', {name:sport2Value})
        this.basketballCheckbox = this.basketball.locator('mat-pseudo-checkbox')
        this.hockeyCheckbox = this.Hockey.locator('mat-pseudo-checkbox')
        await this.hockeyCheckbox.scrollIntoViewIfNeeded()
        await this.hockeyCheckbox.click()
        await this.basketballCheckbox.scrollIntoViewIfNeeded()
        await this.basketballCheckbox.click()
        await this.page.keyboard.press('Escape')
        await this.chooseFile.scrollIntoViewIfNeeded()
        await this.chooseFile.setInputFiles('first.txt')
        await this.address.click()
        await this.address.fill(address)
        await this.zipcode.fill(zipcode)
        await this.acceptCheckbox.scrollIntoViewIfNeeded()
        await this.acceptCheckbox.click({force:true})
        await this.submit.click()

    }

    getRegistrationSuccess():Locator
    {
        return this.regirstationSuccessfulMessage
    }
}
