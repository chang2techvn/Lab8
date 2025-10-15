using System;

namespace PaymentApp.Refactored
{
// Refactored classes
public class CreditCardPaymentRefactored : IPaymentProcessable, IRefundable, ICardValidatable
{
    private readonly ILogger _logger;
    private readonly INotifier _notifier;

    public CreditCardPaymentRefactored(ILogger logger, INotifier notifier)
    {
        _logger = logger;
        _notifier = notifier;
    }

    public void ProcessPayment(decimal amount)
    {
        _logger.Log($"Processing credit card payment of ${amount}");
        Console.WriteLine($"Processing credit card payment of ${amount}");
        _notifier.Notify($"Credit card payment of ${amount} processed successfully");
    }

    public void Refund(decimal amount)
    {
        _logger.Log($"Refunding ${amount} to credit card");
        Console.WriteLine($"Refunding ${amount} to credit card");
        _notifier.Notify($"Refund of ${amount} processed to credit card");
    }

    public void ValidateCard(string cardNumber)
    {
        _logger.Log($"Validating credit card: {cardNumber}");
        Console.WriteLine($"Validating credit card: {cardNumber}");
        _notifier.Notify($"Credit card {cardNumber} validated successfully");
    }
}
}