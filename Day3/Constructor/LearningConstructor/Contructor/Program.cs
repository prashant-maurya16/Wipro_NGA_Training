using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contructor
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("I am default constructor");
        }

        public Program(int a , int b)
        {
            int c = a + b;
            Console.WriteLine($"sum is:{c}");
            Console.ReadLine();
        }
        public void Show()
        {
            Console.WriteLine("I am show method");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Program p1 = new Program(5, 5);
            p.Show();

        }

    }

}
