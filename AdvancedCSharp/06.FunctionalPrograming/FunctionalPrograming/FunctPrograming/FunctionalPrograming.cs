using System;
using System.Collections.Generic;
using Students;

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
        GetByFirstName.GetStudentByFirstName(students, "2", false);
        
        //GetFirstAndLastName
        FirstAndLastName.GetFirstAndLastName(students, false);
        
        //GetFirstNameLastNameAndAge
        FirsNameLastNameAndAge.GetFirstNameLastNameAndAge(students, false);
        
        //SortStudentsBy
        SortStudentBy.SortStudentByQueryType(students, "lambda", false);
        
        //FilterStudentByEmailAddress
        FilterStudent.FilterStudentsByEmail(students, @"@abv.bg", false);
        
        //FilterStudentByPhoneAddress
        FilterStudent.FilterStudentsByPhone(students, false);
        
        //ExelentStudents
        ExelentStudents.ExelentStudent(students, false);
        
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
        GroupingByGroupName.ByGroupName(students, false);
         
        
    }
}