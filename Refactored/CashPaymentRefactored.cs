using System;

namespace PaymentApp.Refactored
{
public class CashPaymentRefactored : IPaymentProcessable, IRefundable
{
    private readonly ILogger _logger;
    private readonly INotifier _notifier;

    public CashPaymentRefactored(ILogger logger, INotifier notifier)
    {
        _logger = logger;
        _notifier = notifier;
    }

    public void ProcessPayment(decimal amount)
    {
        _logger.Log($"Processing cash payment of ${amount}");
        Console.WriteLine($"Processing cash payment of ${amount}");
        _notifier.Notify($"Cash payment of ${amount} processed successfully");
    }

    public void Refund(decimal amount)
    {
        _logger.Log($"Refunding ${amount} in cash");
        Console.WriteLine($"Refunding ${amount} in cash");
        _notifier.Notify($"Refund of ${amount} processed in cash");
    }
}
}