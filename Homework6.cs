/*

Amanda M Lincoln
CIDM 2315-70 Homework 6

This program performs various operations to highlight the creation, use, and manipulation of lists and dictionaries. Specific operation information for each section of code is
listed in // comments above the applicable line of code.

*/

namespace Homework6;
using System.Collections.Generic;
class Student
{
    public static List <Student> studentList = new List <Student>();
    public int StudentID {set; get;}
    public string StudentName {set; get;}
    public Student (int stu_ID, string stu_name)
    {
        StudentID = stu_ID;
        StudentName = stu_name;
        studentList.Add(this);
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {StudentID}, Student Name: {StudentName}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Populate studentList with 4 student objects
        Student s1 = new Student(111, "Alice");
        Student s2 = new Student(222, "Bob");
        Student s3 = new Student(333, "Cathy");
        Student s4 = new Student(444, "David");

        // Create dictionary gradebook and populate it with 4 key-value pairs
        Dictionary <string, double> gradebook = new Dictionary <string, double> ();
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        // Check gradebook dictionary for key "Tom"; if not present, add new key-value pair to dictionary
        // Adds an additional (optional) Student object to StudentList using an arbitrary student ID; performed so that "Tom" appears in the list generated in the last section of code
        if (gradebook.ContainsKey("Tom") == false)
        {
            gradebook.Add("Tom", 3.3);
            Student s5 = new Student(555,"Tom");
        }

        // Calculate the average GPA of all students in the gradebook and print result to the console
        double sum = 0;
        foreach (var gpa in gradebook)
        {
            sum += gpa.Value;
        }
        double gpa_avg = sum / (gradebook.Count);
        Console.WriteLine($"The average GPA is: {gpa_avg}");

        // Prints out the information for all students that achieved a GPA greater than the average calculated above
        foreach (var gpa in gradebook)
        {
            if (gpa.Value > gpa_avg)
            {
                foreach (Student stu in Student.studentList)
                {
                    if (stu.StudentName == gpa.Key)
                    {
                        stu.PrintInfo();
                    }
                }
            }
        }
    }
}
