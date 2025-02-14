using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{


    //Old class
    sealed class Service
    {
        public void service1()
        {
            Console.WriteLine("we are giving no1 service");
        }
        public void service2()
        {
            Console.WriteLine("we are giving no2 service");
        }


    }

    

    //new class
    static class Work
    { 

         public static void Service3(this Service ser) // using extention method
        {
            Console.WriteLine("I am giving no3 service");
        
        }
        public static void Service4(this Service ser)
        {
            Console.WriteLine("I am giving no4 service");
        }

    }


    internal class Program
    {
        static void Main1(string[] args)
        {

            Service ser = new Service();

            ser.service1();
          
            ser.Service4();
            ser.Service3();
            Console.ReadKey();
        }
    }
}
