using System;

namespace SolidPrinciples
{
    // Interface Segregation and Liskov Substitution Principle
    public interface IWithdrawable
    {
        void Withdraw(double amount);
    }

    public interface IDepositable
    {
        void Deposit(double amount);
    }

    // Open/Closed Principle: Open for extension but closed for modification
    public abstract class BankAccount : IDepositable
    {
        protected double Balance;

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }

    public class SavingsAccount : BankAccount, IWithdrawable
    {
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient Balance");
            }
        }
    }

    public class FixedDeposit : BankAccount
    {
        // No withdrawal allowed, Liskov principle applied
    }

    class Program
    {
        static void Main1(string[] args)
        {
            SavingsAccount savings = new SavingsAccount();
            savings.Deposit(1000);
            savings.Withdraw(500);
            Console.WriteLine("Savings Account Balance: " + savings.GetBalance());

            BankAccount fixedDeposit = new FixedDeposit();
            fixedDeposit.Deposit(2000);
            Console.WriteLine("Fixed Deposit Balance: " + fixedDeposit.GetBalance());
        }
    }
}
