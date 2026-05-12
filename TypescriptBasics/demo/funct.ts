function greet()
{
    console.log("hello");
}

greet();

console.log("==============");

function greeting():void
{
    console.log("Greeting method with void return type")
}

greeting();

console.log("==With Return Type====")

function returnGreeting():string
{
    return "This method returns the value";
}

console.log(returnGreeting());

console.log("===With Parameters====");

function add(a:number, b:number,c:number):number
{
    return a+b+c;
}

console.log(add(2,3,5));

console.log("===Default Parameters===")

function multiply(a:number,b:number,c:number=3):number{
    return a*b*c;
}

console.log(multiply(3,3,9));
console.log(multiply(4,3));

console.log("=====Optional Parameter===");

function greetUser(name:string, age?:number):string{
    return `hello my name is ${name} and age is ${age} is old.`;
}

console.log(greetUser("Rakesh",40));
console.log(greetUser("Ramesh"));

console.log("===Anonymous function using const====");

const anonymousFunction1 = function (name:string):string{
    return "Hello "+name;
}

console.log(anonymousFunction1("Somesh"));

let anonymousFunction2 = function (a:number,b:number):number{
    return a+b;
}

console.log(anonymousFunction2(3,8));

console.log("=== Arrow Function =====");

const ArrowFunction1 = ():void =>
{
    console.log("Arrow Funciton");

}

ArrowFunction1();

const ArrowGreet = (user:string):void =>
{
    console.log("Hello "+user);
}

ArrowGreet("Ramesh");

const ArrowMultiply = (a:number,b:number,c:number,d:number):number=>
{
    return a*b*c*d;
}

console.log(ArrowMultiply(4,3,9,2));

console.log("Method overloading");

function combine(a:number,b:number):number
function combine(a:string,b:string):string

function combine(a:any,b:any):any{
    return a+b;
}

console.log(10,20);

console.log("Hello"," Ram")