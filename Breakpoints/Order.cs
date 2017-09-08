﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Breakpoints
{
    public class Order
    {
        public int OrderNumber { get; set; }

        public DateTime DatePlaced { get; set; }

        public decimal TotalCost => OrderTotal();

        public string Customer { get; set; }

        public IEnumerable<OrderItem> OrderItems { get; set; }

        private decimal OrderTotal()
        {
            return OrderItems?.Sum(item => item.Quantity*item.Price) ?? 0;
        }
    }
}