interface Employee
{
    id:string,
    ename:string,
    department:string 
    
}

interface Employee
{
    salary:number
}

const emp1:Employee = 
{
    id:"A101",
    ename:"Rajesh",
    department:"Finance",
    salary:5000
}

function getEmployeeDetails(emp : Employee):Employee{
    return emp
}

interface Manager extends Employee{
    teamSize:number
}

const manager:Manager =
{
    id:"C101",
    ename:"Rames",
    department:"Finance",
    salary:50000,
    teamSize:10
}

console.log(getEmployeeDetails(emp1))
console.log(getEmployeeDetails(manager))