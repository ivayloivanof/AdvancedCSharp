using System;
using System.Collections.Generic;
using System.Linq;
using StudentsClass;
class FunctionalPrograming
{
    public static void Main()
    {
        //Всяка задача е в отделен метод;
        //За да се принтира резултата, се промяна последния параметър на true на искана задача;

        //CreateClassStudents
        List<Student> students = Student.GetListStudents();

        //Group student by group
        Student.GetStudentByFirstName(students, "2", false);

        //GetFirstAndLastName
        Student.GetFirstAndLastName(students, false);

        //GetFirstNameLastNameAndAge
        Student.GetFirstNameLastNameAndAge(students, false);

        //SortStudentsBy
        Student.SortStudentBy(students, "linq", false);

        //FilterStudentByEmailAddress
        Student.FilterStudentsByEmail(students, @"@abv.bg", false);

        //FilterStudentByPhoneAddress
        Student.FilterStudentsByPhone(students, false);
            
        //ExelentStudents
        Student.ExelentStudents(students, false);
    }
}