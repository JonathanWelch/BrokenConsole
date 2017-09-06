using System;
using System.Collections.Generic;

namespace Debugging
{
    public class Orders : IOrders
    {
        public IEnumerable<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order
                {
                    OrderNumber = 1,
                    DatePlaced = new DateTime(2017,01,01,19,03,22),
                    Customer = "Fred Bloggs",
                    OrderItems = new List<OrderItem>
                    {
                        new OrderItem { ItemCode = "AB123", Price = 10.20m, Quantity = 1},
                        new OrderItem { ItemCode = "EF456", Price = 12.40m, Quantity = 2}
                    }
                },
                new Order
                {
                    OrderNumber = 2, 
                    DatePlaced = new DateTime(2017,01,02,09,16,45),
                    Customer = "Jack Jones"
                },
                new Order
                {
                    OrderNumber = 3,
                    DatePlaced = new DateTime(2017,01,03,23,04,35),
                    Customer = "Sandra Smith",
                    OrderItems = new List<OrderItem>
                    {
                        new OrderItem { ItemCode = "PR459", Price = 2.15m, Quantity = 3}
                    }
                }
            };
        }
    }
}