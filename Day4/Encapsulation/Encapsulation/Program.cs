using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{

    public class VotingApp
    {
        private int Age;
        

        public int GetAge()
        {
            return Age;
        }


        public void SetAge(int age)
        {
            if (age > 18)
            {
                this.Age = age;
                Console.WriteLine("you are eligible for vote");
            }
            else
            {

                //how to do this
                int yearsLeft = 18 - age;
                Console.WriteLine($"You are not eligible to vote. You have to wait {yearsLeft} more year(s).");


                int currentYear = DateTime.Now.Year;
                int eligibleYear = currentYear + yearsLeft;
                Console.WriteLine($"You will be eligible to vote in the year {eligibleYear}.");
            }
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int ag = Convert.ToInt32(Console.ReadLine());
            VotingApp vote = new VotingApp();
           
            vote.SetAge(ag);
            
            Console.ReadLine();


        }
    }
}
