﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyPrgram
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Threading.Tasks;
    using EncapsulationExample;

    namespace EncapsulationExample
    {
        internal class PolyProgram
        {

            //Method Overloading
            public void Add(int a, int b)
            {
                Console.WriteLine("The sum is :" + (a + b));
            }

            public void Add(float a, float b)
            {
                Console.WriteLine("The sum is :" + (a + b));
            }

            public void Add(string a, string b)
            {
                Console.WriteLine(a + " " + b);
            }

            public void Add(int a, int b, int c)
            {
                Console.WriteLine(a + b + c);
            }

            public void Add(float a, int b)
            {
                Console.WriteLine(a + b);
            }

            public void Add(int a, float b)
            {
                Console.WriteLine(a + b);
            }



        }

        //
        //Method Overriding
        class Class1
        {
            public void interest()
            {
                //Parent class logic is same for all child classes
                Console.WriteLine("Parent class interest calculated  :");

            }


        }

        class savingAccount : Class1
        {

            public void interest()
            {
                //redefining the method show()
                int a = 20, b = 20;
                base.interest();
                Console.WriteLine(" child class interest calculated as 5%");


            }


        }

        class LoanAccount : savingAccount
        {

            public void interest()
            {
                //redefining the method show()
                int a = 20, b = 20;
                Console.WriteLine("10%");


            }

        }

    }
}
