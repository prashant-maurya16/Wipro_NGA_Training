using System;

namespace PaymentProcessingSystem
{
    // Interface Segregation Principle: Creating a separate interface for processing payments
    public interface IPaymentMethod
    {
        void ProcessPayment(double amount);
    }

    // Single Responsibility Principle: Each class has a single responsibility
    public class CreditCard : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Credit Card payment processed: " + amount);
        }
    }

    public class PayPal : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("PayPal payment processed: " + amount);
        }
    }

    // Open/Closed Principle: New payment methods can be added without modifying existing code
    public class BankTransfer : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Bank Transfer payment processed: " + amount);
        }
    }

    // Dependency Inversion Principle: PaymentProcessor depends on abstraction (IPaymentMethod) instead of concrete classes
    public class PaymentProcessor
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void ExecutePayment(double amount)
        {
            _paymentMethod.ProcessPayment(amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Liskov Substitution Principle: We can replace CreditCard with PayPal or BankTransfer without breaking the system
            IPaymentMethod paymentMethod = new CreditCard(); // Change this to PayPal or BankTransfer to test other methods
            PaymentProcessor processor = new PaymentProcessor(paymentMethod);
            processor.ExecutePayment(1500);
        }
    }
}
