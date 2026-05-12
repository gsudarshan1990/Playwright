class StaticExample
{
    static id:string = "A2020";
    nameValue:string;

    constructor(name:string)
    {
        this.nameValue=name;
    }

    static companyName():string
    {
        return "TechCompany";
    }

    showEmployee()
    {
        console.log("employee Name - ",this.nameValue);
    }
}

const s = new StaticExample("Rajesh");
s.showEmployee();
console.log("Employee ID",StaticExample.id);
console.log("Company Name:",StaticExample.companyName());