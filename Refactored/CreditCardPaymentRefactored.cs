using System;

namespace PaymentApp.Refactored
{
// Refactored classes
public class CreditCardPaymentRefactored : IPaymentProcessable, IRefundable, ICardValidatable
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