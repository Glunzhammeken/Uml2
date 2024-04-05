using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml2_Maybe
{
    public class Store
    {
        static PizzaController PC = new PizzaController();
        static CustomerController CC = new CustomerController();
        static OrderController OC = new OrderController();



        public void test() 
        {
            Pizza Pizza1 = new Pizza();
            Pizza1.Name = "Calzone";
            Pizza1.Price = 100;
            Pizza1.Id = 1;

            PC.AddPizzaTest(Pizza1);

            Pizza Pizza2 = new Pizza();
            Pizza2.Name = "Pepperoni";
            Pizza2.Price = 90;
            Pizza2.Id = 2;

            PC.AddPizzaTest(Pizza2);

            Pizza Pizza3 = new Pizza();
            Pizza3.Name = "Skinke Med Svampe";
            Pizza3.Price = 120;
            Pizza3.Id = 3;

            PC.AddPizzaTest(Pizza3);

            Adresse adressefor1 = new Adresse();
            adressefor1.city = "køge";
            adressefor1.streetname = "vestergade";
            adressefor1.streetnumber = "1";
            adressefor1.zipcode = "4600";

            Adresse adressefor2 = new Adresse();
            adressefor2.city = "søborg";
            adressefor2.streetname = "Hurlumhejgade";
            adressefor2.streetnumber = "3";
            adressefor2.zipcode = "2600";

            Adresse adressefor3 = new Adresse();
            adressefor3.city = "new york";
            adressefor3.streetname = "central park";
            adressefor3.streetnumber = "80";
            adressefor3.zipcode = "7000";


            Customer customer1 = new Customer();
            customer1.Name = "John Dillermand";
            customer1.PhoneNumber = "40404040";
            customer1.Adresse = adressefor1;
            customer1.Id = 1;
            CC.AddCustomerTest(customer1);

            Customer customer2 = new Customer();
            customer2.Name = "Bo";
            customer2.PhoneNumber = "30303030";
            customer2.Adresse = adressefor2;
            customer2.Id = 2;
            CC.AddCustomerTest(customer2);
            Customer customer3 = new Customer();
            customer3.Name = "Leif";
            customer3.PhoneNumber = "20202020";
            customer3.Adresse = adressefor3;
            customer3.Id = 3;
            CC.AddCustomerTest(customer3);

        }

    }
}
