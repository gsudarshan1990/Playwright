interface User
{
    id:string,
    uname:string,
    email:string
}
/*
Before reopening
const user1:User = {
    id:"A101",
    uname :"Rajesh", 
    email:"rajesh@gmail.com"
}
*/
interface User
{
    role:string
}

const user1:User = {
    id:"A101",
    uname :"Rajesh", 
    email:"rajesh@gmail.com",
    role:"Lecturers"
}

interface admin extends User
{
    admin :string
}

const admin1:admin = {
    id:"B101",
    uname :"Ramesh", 
    email:"Ramesh@gmail.com",
    role:"Lecturers1",
    admin :"Level1"
}


console.log(user1);
console.log(admin1);

function createUser(user:User):User 
{
    return user;
}

console.log(createUser(user1))
console.log(createUser(admin1))