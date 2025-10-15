using System;

namespace PaymentApp.Refactored
{
public class CashPaymentRefactored : IPaymentProcessable, IRefundable
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing cash payment of ${amount}");
    }

    public void Refund(decimal amount)
    {
        Console.WriteLine($"Refunding ${amount} in cash");
    }
}
}