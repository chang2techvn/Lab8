using System;

namespace PaymentApp.Refactored
{
public class ConsoleNotifier : INotifier
{
    public void Notify(string message)
    {
        Console.WriteLine($"[NOTIFICATION] {message}");
    }
}
}