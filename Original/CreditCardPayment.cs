using System;

namespace PaymentApp.Original
{
// CreditCardPayment - implements all methods
public class CreditCardPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ${amount}");
    }

    public void Refund(decimal amount)
    {
        Console.WriteLine($"Refunding ${amount} to credit card");
    }

    public void ValidateCard(string cardNumber)
    {
        Console.WriteLine($"Validating credit card: {cardNumber}");
    }
}
}