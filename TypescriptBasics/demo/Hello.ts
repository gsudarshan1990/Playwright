console.log("Hello World")
console.log("Hello! Welcome to Typescript Basics")

let age:number = 10;
let salary:number;

salary = 10000;

let wt=45;
let d;
console.log(d,"type of d", typeof d)

let name:string ="Rakesh";
let marks: number =98;
let negativeValue:number = -68;
let isActive:boolean = true;
let extraValue:null = null;
let nonassigned:undefined = undefined;
let s1:symbol= Symbol("id");

let friend1:string ="Rahul";
let value:number = 10;


console.log("================")


console.log("type of name", typeof name)
console.log("type of marks", typeof marks)
console.log("type of negativeValue",typeof negativeValue)
console.log("type of isActive", typeof isActive)
console.log("typeof extraValue",typeof extraValue)
console.log("type of non assigned",typeof undefined)
console.log("type of s1",typeof s1)


console.log("=========")

let eid: string | number = 101
console.log("type of eid", typeof eid)
eid ="A101";
console.log("type of eid",typeof eid)

console.log("==============")

let data:any ="Hello"
console.log("type of data", typeof data)
data = 100
console.log("type of data",typeof data)
data = true
console.log("type of data", typeof data )

console.log("==========")

let name1:string = "Suresh"
let city : string ="Hyderabad"

let msg = `My name is ${name1}
and my city is ${city}
thats all about me
`

console.log(msg)