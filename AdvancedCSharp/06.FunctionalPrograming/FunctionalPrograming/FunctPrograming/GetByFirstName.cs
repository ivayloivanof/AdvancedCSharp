using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    public static class GetByFirstName
    {
        public static void GetStudentByFirstName(List<Student> students, string groups, bool print)
        {
            var groupTwoStudents =
            from st in students
            where st.GroupNumber == groups
            orderby st.FirstName
            select st;

            if (print)
            {
                foreach (var st in groupTwoStudents)
                {
                    Console.WriteLine(
                        "First Name = {0}, Last Name = {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}, Group Number = {7}",
                        st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone, st.Email, string.Join(" ", st.Marks),
                        st.GroupNumber);
                }
            }
        }
    }
}
