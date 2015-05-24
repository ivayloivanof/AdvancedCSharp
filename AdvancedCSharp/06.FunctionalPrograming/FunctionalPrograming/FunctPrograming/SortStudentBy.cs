using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Students
{
    class SortStudentBy
    {
        public static void SortStudentByQueryType(List<Student> students, string queryType, bool print)
        {
            if (queryType.Contains("lambda"))
            {
                var sortWithLambda = students.OrderByDescending(st => st.FirstName)
                    .ThenByDescending(st => st.LastName)
                    .Select(st => (string.Format("{0} {1}", st.FirstName, st.LastName)));
                if (print)
                {
                    Console.WriteLine("With Lambda:");
                    foreach (string s in sortWithLambda)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            if (queryType.Contains("linq"))
            {
                var sortWithLinq = from st in students
                                   orderby st.FirstName descending, st.LastName descending
                                   select st;
                if (print)
                {
                    Console.WriteLine("With LINQ:");
                    foreach (var student in sortWithLinq)
                    {
                        StringBuilder str = new StringBuilder();
                        str.Append(student.FirstName);
                        str.Append(" ");
                        str.Append(student.LastName);
                        Console.WriteLine(str.ToString());
                    }
                }
            }

        }
    }
}
