using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using StudentsClass;

namespace GroupingStudents
{
    public static class GroupingByGroupName
    {
        public static void ByGroupName(List<Student> students, bool print)
        {
            var groupName = from student in students
                group student by student.GroupNumber;
            if (print)
            {
                foreach (IGrouping<string, Student> grouping in groupName)
                {
                    Console.WriteLine("Group name: {0}, Students: {1}", grouping.Key, grouping.Count());
                    foreach (Student student in grouping)
                    {
                        Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
                    }
                    Console.WriteLine(new string('-', 50));
                }
            }
        }
    }
}
