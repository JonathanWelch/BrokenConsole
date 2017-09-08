using System;

namespace Breakpoints
{
    public class OrdersPrinter
    {
        private readonly IOrders _orders;

        public OrdersPrinter(IOrders orders)
        {
            _orders = orders;
        }

        public void PrintAll()
        {
            var orders = _orders.GetOrders();

            foreach (var order in orders)
            {
                PrintOrder(order);
            }
        }

        private static void PrintOrder(Order order)
        {
            Console.WriteLine($"Date placed: {order.DatePlaced}, " +
                              $"Order Number: {order.OrderNumber}, " +
                              $"Total Cost: {order.TotalCost}, " +
                              $"Customer: {order.Customer}");
        }
    }
}