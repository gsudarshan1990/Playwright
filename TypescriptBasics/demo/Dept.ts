class Dept
{
    employees :string[] = [];
    nameDept: string;
    private role:string;

    constructor(departmentName:string, roleValue :string)
    {
        this.nameDept = departmentName;
        this.role = roleValue;
    }

    addEmployee(employee:string)
    {
        this.employees.push(employee);
    }

    printEmployee()
    {
        console.log("Employee Names");
        for(let emp in this.employees)
        {
            console.log(this.employees[emp]);
        }
    }

    getRole()
    {
        return this.role;
    }
}

const d = new Dept("HR Department","Recruting");
console.log("Department Name - "+d.nameDept);
console.log("Role - "+d.getRole());
d.addEmployee("Rajesh");
d.addEmployee("suresh");
d.addEmployee("Ramu");
d.addEmployee("Parthasarathy");
d.printEmployee();
