using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StudentsClass
{
	public class Student
	{
	    public string FirstName { get; set; }
	    public string LastName { get; set; }
	    public int Age { get; set; }
	    public string FacultyNumber { get; set; }
	    public string Phone { get; set; }
	    public string Email { get; set; }
	    public string GroupNumber { get; set; }
	    public IList<int> Marks { get; set; }
        
	    public Student(string firstName, string lastName, int age, string facultyNumber, string phone, string email, IList<int> marks, string groupNumber)
	    {
	        this.FirstName = firstName;
	        this.LastName = lastName;
	        this.Age = age;
	        this.FacultyNumber = facultyNumber;
	        this.Phone = phone;
	        this.Email = email;
	        this.Marks = marks;
	        this.GroupNumber = groupNumber;
	    }

	    public static List<Student> GetListStudents()
	    {
            string pathFileWithStudents = @"../../Students-data.txt";
            var students = new List<Student>();
            using (StreamReader reader = new StreamReader(pathFileWithStudents))
            {
                Random random = new Random();
                int i = 1;
                while (true)
                {
                    int randomNumber = random.Next(876000000, 899000000);
                    int randomAge = random.Next(18, 55);
                    string line = reader.ReadLine();
                    if (line == null)
                        break;
                    if (i == 1)
                    {
                        i++;
                        continue;
                    }
                    string[] words = line.Split('\t');
                    students.Add(new Student(words[1], words[2], randomAge, i.ToString(), randomNumber.ToString(),
                                words[3], new List<int> { 1, 2, 3 }, words[7].ToString()));
                    i++;
                }
            }
	        return students;
	    }

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

        public static void GetFirstNameLastNameAndAge(List<Student> students, bool print)
        {
            var studentByAge =
                from st in students
                where (st.Age >= 18 && st.Age >= 24)
                select new {st.FirstName, st.LastName, st.Age};

            if (print)
            {
                foreach (var st in studentByAge)
                {
                    Console.WriteLine(  "First Name = {0}, Last Name = {1}, Age = {2}",
                                        st.FirstName, st.LastName, st.Age);
                }
            }
        }
    }
}

