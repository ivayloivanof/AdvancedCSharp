using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using StudentsClass;

namespace StudentEnrolled   
{
    public static class StudentEnrolled
    {
        public static List<Student> Enrolled(this List<Student> students)
        {
            Regex regex = new Regex(@"\d14");
            var enrolledStudents = from student in students
                where regex.IsMatch(student.FacultyNumber)
                select student;
            return enrolledStudents.ToList();
        }
    }
}
