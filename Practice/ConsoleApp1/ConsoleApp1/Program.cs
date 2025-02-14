using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter student registration number:");
            int Reg= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter student registration Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Student Marks1:");
            int marks1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Marks2:");
            int marks2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Student Detail........\n");

            Console.WriteLine($"Sudent registration number is:{Reg}");
            Console.WriteLine($"Student Name:{Name}");
            if(marks1<100)
            {
                Console.WriteLine($"Student Marks1 out of 100:{marks1}");
            }
            else
            {
                Console.WriteLine($"Student Marks1 Should be less than or equal to 100");
            }
           
            if(marks2<100)
            {
                Console.WriteLine($"Student Marks2 out of 100:{marks2}");
            }

            else
            {
                Console.WriteLine($"Student Marks1 Should be less than or equal to 100");

            }

            int Total = marks1 + marks2;
            Console.WriteLine($"Total Marks of student:{Total}");

            int avg = Total / 2;
            Console.WriteLine($"Average Marks of Student is:{avg}");
            
            Console.ReadKey();








        }
    }
}
