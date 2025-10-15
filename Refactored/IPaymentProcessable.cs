namespace PaymentApp.Refactored
{
// Refactored interfaces to adhere to ISP
public interface IPaymentProcessable
{
    void ProcessPayment(decimal amount);
}
}