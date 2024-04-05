using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml2_Maybe
{
    public class OrderDatalayer
    {
        List<Order> orders = new List<Order>();
        public OrderDatalayer()

        { }
        public Order AddOrder(Order o)
        {
            foreach (Order order in orders) { if (o.Id == order.Id) { throw new FormatException("This id already excist - NO ORDER CREATED"); } }
            orders.Add(o);
            return (o);
        }
    }
}
