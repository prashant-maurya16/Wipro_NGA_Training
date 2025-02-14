using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{

    public class InvalidAgeException : Exception
    {
        public override string Message
        {
            get
            {
                return " Age should be Greater than 18 for eligibilty";

            }


        }
    }
    internal class Program
    {


    

        static void Main4(string[] args)
        {
            try
            {
                int age;
                Console.WriteLine("Enter you age:");
                age = Convert.ToInt32(Console.ReadLine());

                if (age<18)
                {
                    throw new InvalidAgeException();
                    Console.WriteLine("Age should be more than 18");
                }
                else
                {
                    Console.WriteLine("You are eligible");
                }
            }
            catch(InvalidAgeException ex)
            {
                Console.WriteLine("The exception has occured :" + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
