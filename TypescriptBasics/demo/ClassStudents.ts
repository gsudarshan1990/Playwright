/*
create a class with 
 A private property courseName (string) using constructor shorthand
 An array students (string[]) initialized as empty
 Constructor
 Use access modifier directly in constructor parameter to declare and initialize courseName
 Methods
 addStudent(student: string)
 → Adds a student to the course
 printStudents()
 → Prints all student names using a loop
 getCourseName()
 → Returns the course name (getter method)
 Object Creation
 Create an object of the class
 Add at least 3 students
 Print course name and student list
*/

class UniversityStudents
{
    constructor(private courseName:string){}

    students:string[] =[];

    addStudent(student:string)
    {
        this.students.push(student)
    }

    printStudents()
    {
        console.log("==Student Names===");
        for(let name of this.students)
        {
            console.log(name);
        }
    }

    getCourseName():string
    {
        return this.courseName;

    }

}

const undergraduate = new UniversityStudents("Artificial Intelligence");
undergraduate.addStudent('Rakesh');
undergraduate.addStudent("Suresh");
undergraduate.addStudent("bhavesh");
undergraduate.printStudents();
console.log("===Course Name===")
console.log(undergraduate.getCourseName());