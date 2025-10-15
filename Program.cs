// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using PaymentApp.Original;
using PaymentApp.Refactored;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Demonstrating LSP and ISP Violations ===");

        // LSP: All payments can be treated as IPaymentProcessor
        List<IPaymentProcessor> payments = new List<IPaymentProcessor>
        {
            new CreditCardPayment(),
            new PayPalPayment(),
            new CashPayment()
        };

        foreach (var payment in payments)
        {
            payment.ProcessPayment(100);
            payment.Refund(50);
            try
            {
                payment.ValidateCard("1234-5678-9012-3456"); // ISP violation - not all need this
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("=== Refactored to adhere to LSP and ISP ===");

        // LSP: All payments implement IPaymentProcessable and can be substituted
        List<IPaymentProcessable> refactoredPayments = new List<IPaymentProcessable>
        {
            new CreditCardPaymentRefactored(),
            new PayPalPaymentRefactored(),
            new CashPaymentRefactored()
        };

        foreach (var payment in refactoredPayments)
        {
            payment.ProcessPayment(100);

            // ISP: Only call methods that are implemented
            if (payment is IRefundable refundable)
            {
                refundable.Refund(50);
            }

            if (payment is ICardValidatable validatable)
            {
                validatable.ValidateCard("1234-5678-9012-3456");
            }

            Console.WriteLine();
        }
    }
}
