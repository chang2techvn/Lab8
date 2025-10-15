using System;

namespace PaymentApp.Original
{
// CashPayment - violates ISP
public class CashPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing cash payment of ${amount}");
    }

    public void Refund(decimal amount)
    {
        Console.WriteLine($"Refunding ${amount} in cash");
    }

    public void ValidateCard(string cardNumber)
    {
        throw new NotImplementedException("Cash payments don't use cards!");
    }
}
}