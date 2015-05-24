using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class FirstAndLastName
    {
        public static void GetFirstAndLastName(List<Student> students, bool print)
        {
            var firstAndLastName =
                from st in students
                where st.FirstName.CompareTo(st.LastName) < 0
                select st;

            if (print)
            {
                foreach (var st in firstAndLastName)
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
