using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Uml2_Maybe
{
    public class PizzaController
    {
        static PizzaDatalayer PD = new PizzaDatalayer();

        
        public PizzaController() 
        
        { }
        public void AddPizzaTest(Pizza p) 
        { PD.AddPizza(p); }

        public Pizza Addpizza(string name, int price, int id)
        {
            Pizza p = new Pizza();

            p.Name = name;

            if (price < 0 || price > 200) { throw new FormatException("Price must be between the numbers 0 and 200 - NO PIZZA CREATED"); } 
          
            p.Price = price;
           
            if (id < 0) { throw new FormatException("Id must be a posetive number - NO PIZZA CREATED"); }

            p.Id = id;
            
                PD.AddPizza(p);
                return p;
        }
        public void DeletePizza(int id)
        {
            
            PD.DeletePizza(id);
        }
        public  Pizza SearchForPizza(int id)
        {
            return PD.SearchForPizza(id); 
        }
        public Pizza UpdatePizza( Pizza pizza ,int NewPrice, string NewName) 
        {
            
            if (NewPrice < 0 || NewPrice > 200) { throw new FormatException("Price must be Between the numbers 0 and 200 - NO PIZZA UPDATED"); }
            return  PD.UpdatePizza(pizza, NewPrice, NewName);
           
            
        }
        public Pizza AddPizzaToOrder(int id)
        {  
            Pizza pizzaToOrder = PD.AddPizzaToOrder(id);
            
            return pizzaToOrder;
        }
        public string PrintMenu()
        {
            
            return PD.PrintMenu();
            
            
        }
    }
}
