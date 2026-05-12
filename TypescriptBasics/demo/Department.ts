class Department
{
    department1 = "Accounting";
    department2 = "Finance";

    describe()
    {
        console.log("Name of the depatment "+this.department1);
        console.log("Name of the department",this.department2);
    }

}
const department = new Department();
department.describe();