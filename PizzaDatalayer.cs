using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Uml2_Maybe
{
    public class PizzaDatalayer
    {
        List<Pizza> pizzas = new List<Pizza>();
        public PizzaDatalayer()
        {

        }
        public Pizza AddPizza(Pizza p)
        {
            

            foreach (Pizza pizza in pizzas) { if (p.Id== pizza.Id) { throw new FormatException("This id already excist - NO PIZZA CREATED"); } }
            pizzas.Add(p);
            return (p);

        }

        public void DeletePizza(int id)
        {
            foreach (Pizza p in pizzas)
            {
                if (p.Id == id)
                {
                    pizzas.Remove(p);

                }
                else throw new FormatException("No pizza with that Id - NO PIZZA DELETED");
            }

           
        }

        public Pizza SearchForPizza(int Id)
        {
           
            foreach (Pizza p in pizzas)

            { if (p.Id == Id)
                {
                    return p; 
                }   
                    
            }
            return null;
        }

        public Pizza UpdatePizza(Pizza pizza, int NewPrice, string NewName)
        {
            
            foreach (Pizza p in pizzas)
            { if (p.Id == pizza.Id)

                { 
                    p.Name = NewName;
                    p.Price = NewPrice;
                    return p;

                }
                
            }
            return null;
        }
        public string PrintMenu()
        {
          StringBuilder sb = new StringBuilder();
            foreach (Pizza pizza in pizzas) { sb.Append(pizza);  } return sb.ToString();
        }

        public Pizza AddPizzaToOrder(int id)
        {
            foreach (Pizza p in pizzas)
            {
                if (id == p.Id)
                {
                    Pizza pizzaToOrder = new Pizza();
                    p.Price = pizzaToOrder.Price;
                    p.Id = pizzaToOrder.Id;
                    p.Name = pizzaToOrder.Name;
                    
                    return pizzaToOrder;
                }
            }
            return null;
        }

    }
}
