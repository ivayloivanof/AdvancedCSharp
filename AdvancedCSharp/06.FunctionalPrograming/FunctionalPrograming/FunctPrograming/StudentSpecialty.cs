using System;
using System.Collections.Generic;
using System.Linq;

namespace Students
{
    class StudentSpecialty
    {
        public static Dictionary<int, string[]> specialtyName = new Dictionary<int, string[]>();

        public static void JoinStudent(List<Student> students, bool print)
        {
            foreach (KeyValuePair<int, string[]> keyValuePair in specialtyName)
            {
                var studentSpec =
                        from student in students
                        where student.FacultyNumber == keyValuePair.Key.ToString()
                        orderby student.FirstName
                        select student;

                if (print)
                {
                    foreach (var st in studentSpec)
                    {
                        Console.WriteLine(
                            "First Name = {0}, Last Name = {1}, Age = {2}, Faculty Number = {3}, Phone = {4}, Email = {5}, Marks = {6}, Group Number = {7}",
                            st.FirstName, st.LastName, st.Age, st.FacultyNumber, st.Phone, st.Email, string.Join(" ", st.Marks),
                            st.GroupNumber);
                    }
                }
            }
        }

        public static void SetSpecialtyNameAndNumber()
        {
            specialtyName.Add(203114, new[] { "Web Developer" });
            specialtyName.Add(203314, new[]
                                            {
                                                "Web Developer",
                                                "QA Engineer"
                                            });
            specialtyName.Add(203914, new[]
                                            {
                                                "Web Developer",
                                                "PHP Developer"
                                            });
            specialtyName.Add(203814, new[] { "PHP Developer" });
        }
    }
}
