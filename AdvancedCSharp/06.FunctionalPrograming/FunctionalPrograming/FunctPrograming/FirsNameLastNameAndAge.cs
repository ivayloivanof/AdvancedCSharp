using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class FirsNameLastNameAndAge
    {
        public static void GetFirstNameLastNameAndAge(List<Student> students, bool print)
        {
            var studentByAge =
                from st in students
                where (st.Age >= 18 && st.Age >= 24)
                select new { st.FirstName, st.LastName, st.Age };

            if (print)
            {
                foreach (var st in studentByAge)
                {
                    Console.WriteLine("First Name = {0}, Last Name = {1}, Age = {2}",
                                        st.FirstName, st.LastName, st.Age);
                }
            }
        }
    }
}
