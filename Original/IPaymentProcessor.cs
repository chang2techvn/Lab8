using System;

namespace PaymentApp.Original
{
// Original code - violates ISP and demonstrates LSP
public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
    void Refund(decimal amount);
    void ValidateCard(string cardNumber);
}
}