import {When, Then, Before} from '@cucumber/cucumber'
import {request,expect} from '@playwright/test'


let userIdFromPost:number
let bearerToken: string

Before(async function ()
{
    this.apicontext = await request.newContext({
        'baseURL':'https://lkmdemoaut.accenture.com/AccenSportzRestApi/'
    })
})
       
When('user generates the bearer token.This REST API endpoint is secured and requires {string} for access.', async function (string) {
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

this.getBearerToken = await this.apicontext.get('getBearerToken',{
        headers:{
            'accept': '*/*',
            'userid':userIdFromPost.toString(),
            'password':'pass123456'
        }
    })
    
});


Then('Response should be successful for the get request for bearer token',async function () {
// Write code here that turns the phrase above into concrete actions
    expect(this.getBearerToken.status()).toBe(200)
    expect(this.getBearerToken.ok()).toBeTruthy()
    bearerToken = await this.getBearerToken.text()
});




When('Retrieves the list of all the games available on AccenSportz', async function () {
// Write code here that turns the phrase above into concrete actions

    this.getAllGamesResponse = await this.apicontext.get('getAllGames',{
        headers:{
            'Authorization':bearerToken,
            'userid': userIdFromPost.toString()
        }
    })

    console.log(await this.getAllGamesResponse.json())
});


Then('Response should be successful for the get request related to all the games', function () {
// Write code here that turns the phrase above into concrete actions

    expect(this.getAllGamesResponse.status()).toBe(200)
    expect(this.getAllGamesResponse.ok()).toBeTruthy()
   
});




When('Retrieve the list of games associated with a specific category', async function () {
// Write code here that turns the phrase above into concrete actions

    const options: string[] =['Indoor','Outdoor']

    const randomIndex = Math.floor(Math.random()*options.length)
    
    const param:string = 'getGamesCategory/'+options[randomIndex]

     this.getGamesCategoryResponse = await this.apicontext.post(param,{
        headers:{
            "accept": "*/*",
            'Authorization':bearerToken,
            'userid': userIdFromPost.toString()
        }
    })

    console.log(await  this.getGamesCategoryResponse.json())

});

Then('Response should be successful for the post request for specific category', function () {
// Write code here that turns the phrase above into concrete actions
   
    
 expect(this.getGamesCategoryResponse.status()).toBe(200)
    expect(this.getGamesCategoryResponse.ok()).toBeTruthy()
});
