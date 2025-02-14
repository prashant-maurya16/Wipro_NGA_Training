using System;

namespace Delegate
{

   public class DelegateExample
    {

        public delegate void PrintDelegate();  //creating delegate
        public delegate void Operation(int a, int b);
        public static void Main(string[] args)
        {
            PrintDelegate pd = new PrintDelegate(printData);
            pd();
            Operation op = new Operation(Add);
            Add(25, 5);
        }

       
        public   static void printData() //creating an object of a delgate class, which will point to a method
        {
            Console.WriteLine("Delegate associated Method has called");
        }
        public static void Add(int a, int b)
        {
            Console.WriteLine($"Sum of two number:{a + b}");
        }
    }

}
