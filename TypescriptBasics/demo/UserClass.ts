class User
{
    name:string;
    age:number;

    constructor(newname:string, newage:number)
    {
        this.name = newname;
        this.age = newage;
    }

    userDetails()
    {
        console.log("Name is",this.name);
        console.log("Age is",this.age);
    }
}

const user= new User("Rajesh",32);
user.userDetails();