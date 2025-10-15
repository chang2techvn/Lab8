using System;

namespace PaymentApp.Original
{
// PayPalPayment - violates ISP by implementing methods it doesn't need
public class PayPalPayment : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of ${amount}");
    }

    public void Refund(decimal amount)
    {
        Console.WriteLine($"Refunding ${amount} via PayPal");
    }

    public void ValidateCard(string cardNumber)
    {
        throw new NotImplementedException("PayPal doesn't require card validation!");
    }
}
}