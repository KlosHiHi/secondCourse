public class PaymentProccessor
{
    private  IPaymentStrategy _strategy;


    public void ProcessPayment(int cost)
        => _strategy?.Pay(cost);

    public void ChangePaymentStrategy(IPaymentStrategy strategy)
        => _strategy = strategy;
}
