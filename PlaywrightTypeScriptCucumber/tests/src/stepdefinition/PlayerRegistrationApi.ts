import {When, Then, Before} from '@cucumber/cucumber'
import {request, expect} from '@playwright/test'

let userIdFromPost: string

Before(async function (){

    this.apicontext = await request.newContext({
        baseURL:'https://lkmdemoaut.accenture.com/AccenSportzRestApi/'
    })
})




When('Register a new user with AccenSportz.', async function () {
// Write code here that turns the phrase above into concrete actions
this.postResponse = await this.apicontext.post('addNewUser',{
    headers:{
        'accept': '*/*',
        'Content-Type': 'application/json'
    },
    data:{
            "address": "Hyderabad",
            "age": 32,
            "dateofBirth": "1994-01-30",
            "emailId": "johnbryant@gmail.com",
            "firstName": "John",
            "gender": "Male",
            "lastName": "Bryant",
            "password": "pass123456",
            "phoneNo": 9988776695,
            "weight": 108,
            "zipcode": 500806
    }
})

    userIdFromPost = (await this.postResponse.json()).userID

});


Then('Response should be successful for the post request', function () {
// Write code here that turns the phrase above into concrete actions
    expect(this.postResponse.status()).toBe(200)
    expect(this.postResponse.ok()).toBeTruthy()

});


       
When('Retrieve user details from AccenSportz.',{timeout:10000}, async function () {
// Write code here that turns the phrase above into concrete actions

    this.getResponse = await this.apicontext.get('getUserDetails?userid='+userIdFromPost)
  

});


Then('Response should be successful for the get request',async function () {
// Write code here   that turns the phrase above into concrete actions

    var resp = this.getResponse
    expect(resp.status()).toBe(200)
    expect(resp.ok()).toBeTruthy()
});

       
When('Update the user with AccenSportz.',async  function () {
// Write code here that turns the phrase above into concrete actions

    this.putResponse = await this.apicontext.put('updateUserDataWithPut', {
        headers:{
            'accept': '*/*',
            'Content-Type': 'application/json'
        },
        data:{
            "address": "Delhi",
            "age": 29,
            "dateofBirth": "2024-01-30",
            "emailId": "johnsmith@gmail.com",
            "firstName": "John",
            "gender": "Male",
            "lastName": "Smith",
            "password": "pass12345",
            "phoneNo": 9988776655,
            "userID": userIdFromPost,
            "weight": 62,
            "zipcode": 500006
        }
    })

});

Then('Response should be successful for the put request',async  function () {
// Write code here that turns the phrase above into concrete actions

    var putResp = this.putResponse
    expect(putResp.status()).toBe(200)
    expect(putResp.ok()).toBeTruthy()
    this.putResponseJson = await putResp.json()
    this.message = this.putResponseJson.message
    expect(this.message).toContain(userIdFromPost.toString())
});

 
When('Delete the user associated with AccenSportz.', async function () {
// Write code here that turns the phrase above into concrete actions

    this.deleteResponse = await this.apicontext.delete('deleteUser',{
        headers:{
            "accept": "*/*" ,
            "Content-Type": "application/json"
        },
        data:{
            "userID": userIdFromPost
        }
    })

});


Then('Response should be successful for the delete request', async function () {
// Write code here that turns the phrase above into concrete actions

    var delResp = this.deleteResponse
    expect(delResp.status()).toBe(200)
    expect(delResp.ok()).toBeTruthy()
    expect((await delResp.json()).message).toBe('User deleted successfully')
});