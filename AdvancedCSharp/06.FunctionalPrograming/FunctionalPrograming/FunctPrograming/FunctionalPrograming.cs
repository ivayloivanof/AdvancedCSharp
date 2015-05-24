using System;
using System.Collections.Generic;
using StudentsClass;
using WeakStudents;
using StudentEnrolled;
using GroupingStudents;

class FunctionalPrograming
{
    public static void Main()
    {
        //Всяка задача е в отделен метод;
        //За да се принтира резултата, се промяна последния параметър на true на искана задача;
        //На foreach-овете се откоментира Console.WriteLine();

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

        //WeakStudent
        var weakStudent = students.WeakStudent();
        foreach (var student in weakStudent)
        {
            //Console.WriteLine("{0} {1} = {2}", student.FirstName, student.LastName, string.Join(" ", student.Marks));
        }

        //StudentsEnrolledIn2014
        var studentEnrolled = students.Enrolled();
        foreach (var student in studentEnrolled)
        {
            //Console.WriteLine("{0} {1} = {2}", student.FirstName, student.LastName, string.Join(" ", student.Marks));
        }

        //Grouping student by GroupName
        GroupingByGroupName.ByGroupName(students, true);
    }
}