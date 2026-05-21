class Employee
{
    name:string;
    salary:number

    constructor(fname:string, sal:number)
    {
        this.name = fname
        this.salary = sal
    }

    getDetails()
    {
        console.log("Name:",this.name)
        console.log("Salary:",this.salary)
    }

}

class Manager extends Employee
{
    department:string

    constructor(dept:string,name1:string,sal1:number)
    {
        super(name1,sal1)
        this.department= dept
    }

    getDetails()
    {
        super.getDetails()
        console.log("Department",this.department)
    }
}

const e = new Employee("Ramesh",30000)
e.getDetails()

const m = new Manager("Computer Science", "Suresh",80000)
m.getDetails()