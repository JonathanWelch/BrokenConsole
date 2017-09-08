using System.Collections.Generic;

namespace Breakpoints
{
    public interface IOrders
    {
        IEnumerable<Order> GetOrders();
    }
}