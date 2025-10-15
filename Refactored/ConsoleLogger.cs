using System;
using System.IO;

namespace PaymentApp.Refactored
{
public class FileLogger : ILogger
{
    private readonly string _logFilePath;

    public FileLogger(string logFilePath = "payment.log")
    {
        _logFilePath = logFilePath;
    }

    public void Log(string message)
    {
        string logEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";
        File.AppendAllText(_logFilePath, logEntry + Environment.NewLine);
        Console.WriteLine($"[LOG] {message}"); // Also print to console for demo
    }
}
}