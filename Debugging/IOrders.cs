using System.Collections.Generic;

namespace Debugging
{
    public interface IOrders
    {
        IEnumerable<Order> GetOrders();
    }
}