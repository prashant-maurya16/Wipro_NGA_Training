using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyPrgram
{
    internal class Program
    {

        class BankAccount
        {
            public virtual void Intrest()
            {
                Console.WriteLine("Calculate intrest with rate of 5%");
            }
        }
       
        class SavingAccount:BankAccount
        {
            public override void  Intrest()
            {
                int p = 20000;
                int r = 5;
                int t = 5;
                int i=(p*r*t)/100;
               base.Intrest();
                Console.WriteLine($"Total  intrest 20000 with rate of 5% is :{i}");

            }
        }
        class LoanAccount:SavingAccount
        {
            public  void Intrest()
            {
                base.Intrest();
                    {
                    //  base.Intrest();

                    Console.WriteLine($"You have to pay 5000");
                }
            }

        }

        static void Main6(string[] args)
        {
            LoanAccount loan = new LoanAccount();
            loan.Intrest();
            Console.ReadLine();

        }
    }
}
