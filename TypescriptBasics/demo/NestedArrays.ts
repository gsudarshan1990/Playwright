console.log("======Nested Arrays=====")

let fruit:string[] = Array.of("mango","guava");
let diary:string[] = Array.of("milk","soyamilk");
let bakery:string[] = Array.of("cake","biscuit");

let categories:string[][]=[fruit,diary,bakery];
console.log(fruit);

for(let category of categories)
{
    console.log("=========")
    if(category == fruit)
    {
            console.log("fruit Category")
    }
    if(category == diary)
    {
        console.log("Diary Category")
    }
    if(category == bakery)
    {
        console.log("bakery Category")
    }

    for(let item in category)
    {
        console.log("index:"+item+" name:"+category[item]);
    }
}