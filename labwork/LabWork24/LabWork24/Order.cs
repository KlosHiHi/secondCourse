public class Order
{
    private const double TotalForDiscount = 10000;
    private const double DiscountPercent = 0.1;
    private const double Tax = 0.2;

    private double _total;
    private string _address;

    public bool IsExpress { get; set; }
    public int Id { get; set; }

    public double Total
    {
        get => _total;
        set
        {
            if (value >= 0)
                _total = value;
        }
    }

    public string Address
    {
        get => _address;
        set
        {
            if (value != string.Empty)
                _address = value;
        }
    }

    public double CalculateOrderPrice(Order order)
    {
        if (order.Address == String.Empty)
            throw new OrderException("Нет адреса доставки");

        double discount = order.Total > TotalForDiscount ? order.Total * DiscountPercent : 0;

        return GetFinalPrice(order, discount, DeliveryCost.GetDeliveryCost(order));
    }

    private static double GetFinalPrice(Order order, double discount, double deliveryCost)
        => order.Total - discount + GetTax(order) + deliveryCost;

    private static double GetTax(Order order)
        => order.Total * Tax;
}