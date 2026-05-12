let arr5:(number|string|boolean|null)[] = [10,"Rajesh",true,null];
console.log(arr5);

let arr6: any = [10,"Rakesh",true,null, undefined]
console.log(arr6);
console.log("===========");
let namesArr:string[] = ["Somesh","Suresh","Rakesh","Suresh"]

for(let i=0;i<namesArr.length;i++)
{
    console.log(namesArr[i]);
}

console.log("===========");
for(let i in namesArr)
{
    console.log(namesArr[i]);
}

console.log("=====index======");
for(let name in namesArr)
{
    console.log(name);
}

let arr7 : number[]= Array.of(5);

arr7[0] = 30;
arr7[1] = 50;
arr7[2] = 70;
arr7[3] = 100;
arr7[4] = 150;

console.log(arr7);

for(let i in arr7)
{
    console.log(arr7[i]);
}