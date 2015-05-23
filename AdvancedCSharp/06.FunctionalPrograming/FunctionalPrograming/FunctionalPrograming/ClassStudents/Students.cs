using System;
using System.Collections.Generic;
using System.IO;

namespace ClassStudents
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
         

	    public static void Main(string[] args)
	    {
            string pathFileWithStudents = @"../../Students-data.txt";
            List<object> students = new List<object>();
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

                    Console.WriteLine();
                    students.Add(new Student(words[1], words[2], randomAge, i.ToString(), randomNumber.ToString(),
                                words[3], new List<int> { 1, 2, 3 }, words[7].ToString()));
                    i++;
                }
            }
	        Console.WriteLine();
        }

	    public Student(string firstName, string lastName, int age, 
                       string facultyNumber, string phone, string email,
	                    IList<int> marks, string groupNumber)
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
    }
}

