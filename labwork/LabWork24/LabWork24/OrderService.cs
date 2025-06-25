public class OrderService
{
    private List<Order> orders { get; set; } = [];

    public void AddOrder(Order order)
        => orders.Add(order);

    public void PrintOrderDetails(int orderId)
    {
        var order = GetOrder(orderId);

        if (order == null)
        {
            Console.WriteLine("Заказ не найден.");
            return;
        }

        PrintInfo(order);
    }

    private Order? GetOrder(int orderId)
        => orders.FirstOrDefault(o => o.Id == orderId);

    private static void PrintInfo(Order? order)
    {
        Console.WriteLine("Id Заказа: " + order.Id);
        Console.WriteLine("Стоимость заказа: " + order.Total);
        Console.WriteLine("Адрес: " + order.Address);
        Console.WriteLine("Экспресс доставка: " + (order.IsExpress ? "Да" : "Нет"));
    }
}
