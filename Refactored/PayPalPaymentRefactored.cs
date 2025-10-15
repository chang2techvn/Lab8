using System;

namespace PaymentApp.Refactored
{
public class PayPalPaymentRefactored : IPaymentProcessable, IRefundable
{
    private readonly ILogger _logger;
    private readonly INotifier _notifier;

    public PayPalPaymentRefactored(ILogger logger, INotifier notifier)
    {
        _logger = logger;
        _notifier = notifier;
    }

    public void ProcessPayment(decimal amount)
    {
        _logger.Log($"Processing PayPal payment of ${amount}");
        Console.WriteLine($"Processing PayPal payment of ${amount}");
        _notifier.Notify($"PayPal payment of ${amount} processed successfully");
    }

    public void Refund(decimal amount)
    {
        _logger.Log($"Refunding ${amount} via PayPal");
        Console.WriteLine($"Refunding ${amount} via PayPal");
        _notifier.Notify($"Refund of ${amount} processed via PayPal");
    }
}
}