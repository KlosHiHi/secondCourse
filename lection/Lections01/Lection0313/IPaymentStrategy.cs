public interface IPaymentStrategy
{
    void Pay(int cost);
}


public class CardPayment : IPaymentStrategy
{
    public void Pay(int cost) 
        => Console.WriteLine("pay by card");
}


public class CreditPayment : IPaymentStrategy
{
    public void Pay(int cost)
        => Console.WriteLine("pay by credit");
}