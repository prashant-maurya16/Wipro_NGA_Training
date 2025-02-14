// See https://aka.ms/new-console-template for more information
using System;
using ClassLibrary1;
namespace Program

{
    public class Program
    {
     public   static void Main(string[] args)
        {

        }
    }
    
    public class ConsoleClass: Class1   // dervied class from dll assembly
    {
        public void display()
        {
            Console.WriteLine(Id);  //you cannot access private member withn drive  type(class) in different assembly as well
        }
    }


    public class Class3
    {
        public void display()
        {
            Class1 obj = new Class1();

            Console.WriteLine(obj.Id);  //you cannot access private member within Undrive type(class) in different assembly as well
        }
    }
}


