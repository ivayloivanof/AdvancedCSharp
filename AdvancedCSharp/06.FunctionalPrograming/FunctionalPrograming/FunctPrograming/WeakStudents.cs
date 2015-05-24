using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentsClass;

namespace WeakStudents
{
    public static class WeakStudents
    {
        public static List<Student> WeakStudent(this List<Student> students)
        {
            var weakStudent =
            from student in students
            where (student.Marks.Count(x => x == 2) == 2)
            select student;

            return weakStudent.ToList();
        }
    }
}
