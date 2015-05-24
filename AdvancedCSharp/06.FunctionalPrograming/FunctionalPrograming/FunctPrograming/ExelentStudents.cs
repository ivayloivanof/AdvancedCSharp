using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    class ExelentStudents
    {
        public static void ExelentStudent(List<Student> students, bool print)
        {
            var exelentStudents =
            from student in students
            where student.Marks.Max() == 6
            select student;

            if (print)
            {
                foreach (var student in exelentStudents)
                {
                    StringBuilder str = new StringBuilder();
                    str.Append(student.FirstName);
                    str.Append(" ");
                    str.Append(student.LastName);
                    str.Append(" ===>>> ");
                    str.Append(student.Marks.Max());
                    Console.WriteLine(str.ToString());
                }
            }
        }
    }
}
