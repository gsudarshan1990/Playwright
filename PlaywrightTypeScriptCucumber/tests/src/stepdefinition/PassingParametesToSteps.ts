import {Given, When, Then} from '@cucumber/cucumber'


let usernameg: any
let ageg:any
let salaryg:any
Given('user name is {string}', function (username:string) {
           // Write code here that turns the phrase above into concrete actions
          usernameg= username
         });
       

       
         When('user age is {int}', function (age:number) {
         // When('user age is {float}', function (float) {
           // Write code here that turns the phrase above into concrete actions
           ageg= age
         });
       
   
       
         When('users salary is {int}', function (salary:number) {
         // When('users salary is {float}', function (float) {
           // Write code here that turns the phrase above into concrete actions
           salaryg= salary
         });
       
  
       
         Then('users details is published completely', function () {
           // Write code here that turns the phrase above into concrete actions
           
            console.log("Username:", usernameg)
            console.log("Age",ageg)
            console.log("Salary", salaryg)
         });