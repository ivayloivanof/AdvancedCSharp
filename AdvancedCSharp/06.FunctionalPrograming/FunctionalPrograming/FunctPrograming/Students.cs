using System;
using System.Collections.Generic;
using System.IO;

namespace Students
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
	    public string specialty { get; set; }
	    public int specialtyNumber { get; set; }
        
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
                int j = 1;
                while (true)
                {
                    int randomPhoneNumber = random.Next(876000000, 899000000);
                    int randomAge = random.Next(18, 55);
                    int randomFacultyNumber = random.Next(203000, 204000);
                    List<int> marks = new List<int> { 1, 2, 3, 4, 5, 3 };
                    Dictionary<int, string[]> specialtyName = new Dictionary<int, string[]>();
                    specialtyName.Add(203114, new []{"Web Developer"});
                    specialtyName.Add(203314, new []
                                                    {
                                                        "Web Developer",
                                                        "QA Engineer"
                                                    });
                    specialtyName.Add(203914, new []
                                                    {
                                                        "Web Developer",
                                                        "PHP Developer"
                                                    });
                    specialtyName.Add(203814, new []{"PHP Developer"});

                    string line = reader.ReadLine();
                    if (line == null)
                        break;
                    if (i == 1)
                    {
                        i++;
                        continue;
                    }
                    if (j%7 == 0)
                        marks = new List<int> { 1, 2, 3, 4, 5, 6 };
                    if (j%17 == 0)
                        marks = new List<int> { 2, 3, 2, 3, 4 };
                    string[] words = line.Split('\t');
                    students.Add(new Student(
                                                words[1],   //firstName
                                                words[2],   //lastName
                                                randomAge,  //age
                                                randomFacultyNumber.ToString(), //facultyNumber
                                                randomPhoneNumber.ToString(),   //phoneNumber
                                                words[3],   //
                                                marks,  //
                                                words[7])   //
                                );
                    i++;
                    j++;
                }
            }
	        return students;
	    }
        
    }
}

