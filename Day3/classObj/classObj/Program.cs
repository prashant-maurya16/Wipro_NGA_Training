using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classObj
{
    internal class Program
    {



        public class Add
        {
            // static variabe can be axcessed in a static method only via a class name
            public int c;
           
            //argument based method

            public void input(int a, int b)
            {
                c = a + b;
                Console.WriteLine($"{c}: sum of a+b");
                Console.ReadLine();

            }
        }
         public static void main(string[] args)
        {
            Add A = new Add();
            A.input(5, 10);
        }


    }
}
