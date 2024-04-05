using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml2_Maybe
{
    public class OrderController
    {
        static OrderDatalayer OD = new OrderDatalayer();
        public OrderController()
        { }

        public Order AddOrder(int id, Customer customer) 
        { 
            Order order = new Order();
            order.Id = id;
            order.customer = customer;
            OD.AddOrder(order);
            return order;
        }

        public void AddPizzaToOrder(Pizza p, Order order)
        {
            order.AddPizzaToOrder(p);
        }
    }
}
