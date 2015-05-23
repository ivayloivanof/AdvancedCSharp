using System;
using System.Collections.Generic;
using System.Linq;
using StudentsClass;
class FunctionalPrograming
{
    public static void Main()
    {
        //CreateClassStudents
        List<Student> students = Student.GetListStudents();

        //Group student by group
        Console.WriteLine("Group student by group");
        Student.GetStudentByFirstName(students, "2", false);

        //GetFirstAndLastName
        Student.GetFirstAndLastName(students, false);

        //GetFirstNameLastNameAndAge
        Student.GetFirstNameLastNameAndAge(students, false);
    }
}