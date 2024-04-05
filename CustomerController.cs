using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml2_Maybe
{
    public class CustomerController
    {
        static CustomerDataLayer CD = new CustomerDataLayer();

        public CustomerController() 
        { }

        public void AddCustomerTest(Customer c) {CD.AddCustomer(c);}

        public Customer AddCustomer(string name, string phonenumber , int id, string city, string zipcide, string streetname, string streetnumber) 
        {
            Adresse a = new Adresse();
            a.city = city;
            a.streetname = streetname;
            a.streetnumber = streetnumber;
            a.zipcode = zipcide;
        Customer c = new Customer();
            c.Name = name;
            c.PhoneNumber = phonenumber;
            if (id < 0) { throw new FormatException("Id must be a posetive number - NO CUSTOMER CREATED"); }
            c.Id = id;
            c.Adresse = a;
            CD.AddCustomer(c);
            return c;

        }
        public void DeleteCustomer(int id)
        {
            CD.DeleteCustomer(id);
        }
        public Customer SearchForCustomer(int id)
        {
            return CD.SearchForCustomer(id);
        }
        public Customer UpdateCustomer(Customer customer, string NewPhonenumber, string NewName, string Newcity, string Newzipcide, string Newstreetname, string Newstreetnumber)
        {
            Adresse adresse = new Adresse();
            adresse.streetnumber = Newstreetnumber;
            adresse.city = Newcity;
            adresse.streetname = Newstreetname;
            adresse.zipcode = Newzipcide;
            return CD.UpdateCustomer(customer, adresse, NewName, NewPhonenumber);
        }
        public string PrintMenu()
        {
            return CD.PrintMenu();
        }
       public Customer AddCustomerToOrder(int id)
        {
            Customer customerToOrder = new Customer();
            Customer customerFromList = CD.AddCustomerToOrder(id);
            customerFromList.Adresse = customerToOrder.Adresse;
            customerFromList.PhoneNumber = customerToOrder.PhoneNumber;
            customerFromList.Name= customerToOrder.Name;
            
            return customerToOrder;


        }
    }
}
