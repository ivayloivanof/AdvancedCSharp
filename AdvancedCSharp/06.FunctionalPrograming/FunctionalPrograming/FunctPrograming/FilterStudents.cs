using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Students
{
    class FilterStudent
    {
        public static void FilterStudentsByEmail(List<Student> students, string emailPattern, bool print)
        {
            Regex regex = new Regex(emailPattern);
            var emailGroup =
            from student in students
            where regex.IsMatch(student.Email)
            select student;

            if (print)
            {
                foreach (var student in emailGroup)
                {
                    StringBuilder str = new StringBuilder();
                    str.Append(student.FirstName);
                    str.Append(" ");
                    str.Append(student.LastName);
                    str.Append(" ===>>> ");
                    str.Append(student.Email);
                    Console.WriteLine(str.ToString());
                }
            }
        }

        public static void FilterStudentsByPhone(List<Student> students, bool print)
        {
            var phoneGroup =
            from student in students
            where (student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2") || student.Phone.StartsWith("87"))
            select student;

            if (print)
            {
                foreach (var student in phoneGroup)
                {
                    StringBuilder str = new StringBuilder();
                    str.Append(student.FirstName);
                    str.Append(" ");
                    str.Append(student.LastName);
                    str.Append(" ===>>> ");
                    str.Append(student.Phone);
                    Console.WriteLine(str.ToString());
                }
            }
        }
    }
}
