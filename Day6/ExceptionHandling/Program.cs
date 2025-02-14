using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
         static void Main(string[] args)
        {
            int a;
            int b;
          
            try
            {
                Console.WriteLine("Enter first  number:");
                a =Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Enter second  number:");
                b = Console.ReadLine();
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            


        }
    }
}
