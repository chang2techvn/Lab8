using System;

namespace PaymentApp.Refactored
{
public class PayPalPaymentRefactored : IPaymentProcessable, IRefundable
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount}");
    }

    public void Refund(decimal amount)
    {
        Console.WriteLine($"Refunding ${amount} via PayPal");
    }
}
}