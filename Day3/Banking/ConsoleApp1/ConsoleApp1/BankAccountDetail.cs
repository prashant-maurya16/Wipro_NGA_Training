using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankAccountDetail
    {


        public string AccHolder;
        protected int AccNumber;
        private decimal Balance;
        internal string Bankname;

        public BankAccountDetail(string accHolder, int accNumber, decimal balance, string bankName)
        {

            AccHolder = accHolder;
            AccNumber = accNumber;
            Balance = balance;
            Bankname = bankName;

        }

        // show method
        public void ShowDetail(string AccHolder, string BankName)
        {
            Console.WriteLine("Get account detail");

        }






        static void Main(string[] args)
        {
        }
    }
    //derive class

    public SavingAccount:BankAccountDetail
        {

        }
static void Main(string[]args)
{
    BankAccountDetail B = new BankAccountDetail("Prashant",555454554415,1.100000,"IOB");
    B.ShowDetail()
   


   
}


}
