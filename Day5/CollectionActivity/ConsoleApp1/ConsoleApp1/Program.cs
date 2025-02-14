using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Student
        {
            int Id;
            string Name;
            int Age;
            public Student(int id, string name, int age)
            {
                Id = id;
                Name = name;
                Age = age;
                Console.WriteLine("Enter student detail...");
            }



        }
        
        static void main(string[] args)
        {
        }
    }
}






/*
 
 using System;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(int id, string name, int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }
}

class University
{
    private List<Student> students = new List<Student>();

    // Add student
    public void AddStudent(int id, string name, int age)
    {
        students.Add(new Student(id, name, age));
        Console.WriteLine($"Student {name} added successfully.");
    }

    // Display student list
    public void DisplayStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students in the system.");
            return;
        }

        Console.WriteLine("\nStudent List:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }

    // Remove student by ID
    public void RemoveStudent(int id)
    {
        var student = students.Find(s => s.Id == id);
        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine($"Student with ID {id} removed.");
        }
        else
        {
            Console.WriteLine($"Student with ID {id} not found.");
        }
    }
}

class ArrayList
{
   public static void Main()
    {
        University university = new University();

        // Adding students
        university.AddStudent(1, "Alice", 20);
        university.AddStudent(2, "Bob", 22);
        university.AddStudent(3, "Charlie", 21);

        // Displaying students
        university.DisplayStudents();

        // Removing a student
        university.RemoveStudent(2);

        // Displaying students after removal
        university.DisplayStudents();
    }
}*/
