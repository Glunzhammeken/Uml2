using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Uml2_Maybe
{
    public class Order
    {
        public int Id { get; set; }

        List<Pizza> PizzaInOrder = new List<Pizza>();

        public Customer customer { get; set; }

        public void AddPizzaToOrder(Pizza pizza)
        { PizzaInOrder.Add(pizza); }
        public override string ToString()
        {
            return $" Order Id: {Id}\n Customer: {customer}\n Has Ordered: {PizzaInOrder}\n\n";
        }
    }
}
