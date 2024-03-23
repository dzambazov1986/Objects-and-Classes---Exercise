using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public float Grade { get; set; }
}

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();

        for (int i = 0; i < n; i++)
        {
            string[] studentInfo = Console.ReadLine().Split(' ');
            students.Add(new Student
            {
                FirstName = studentInfo[0],
                LastName = studentInfo[1],
                Grade = float.Parse(studentInfo[2])
            });
        }

        foreach (var student in students.OrderByDescending(s => s.Grade))
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
        }
    }
}
