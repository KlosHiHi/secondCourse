public class DeliveryCost
{
    private const double TotalForFreeDelivery = 3000;
    private const double TotalForDiscountDelivery = 1000;
    private const double DiscountDeliveryPrice = 230;

    public static double GetDeliveryCost(Order order)
    {
        double deliveryCost = 0;
        if (order.Total < TotalForDiscountDelivery)
            deliveryCost = order.Total;
        if (order.Total < TotalForFreeDelivery)
            deliveryCost = DiscountDeliveryPrice;
        if (order.IsExpress)
            deliveryCost *= 2;
        return deliveryCost;
    }
}