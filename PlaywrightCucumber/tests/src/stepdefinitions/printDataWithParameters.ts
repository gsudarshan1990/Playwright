 import {Given,When, Then } from '@cucumber/cucumber'
 
 Given('User is {string}', function (name: string) {
           // Write code here that turns the phrase above into concrete actions
           console.log('username is' ,name)
         });
       
  
       
         When('user is {int} years old', function (age:number) {
         // When('user is {float} years old', function (float) {
           // Write code here that turns the phrase above into concrete actions
           console.log('user is ',age)
         });
       

       
         Then('User gets married has {float}', function (salary:number) {
           // Write code here that turns the phrase above into concrete actions
           console.log("salary is", salary)
         });