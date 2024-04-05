using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml2_Maybe
{
    public class CustomerDataLayer
    {
        List<Customer> customers = new List<Customer>();
        public CustomerDataLayer() 
        { }

        public Customer AddCustomer(Customer c)
        {
            foreach (Customer customer in customers) { if (c.Id == customer.Id) { throw new FormatException("This id already excist - NO CUSTOMER CREATED"); } }
            customers.Add(c);
            return (c);
        }

        public void DeleteCustomer(int id)
        {
            foreach (Customer c in customers)
            {
                if (c.Id == id)
                {
                    customers.Remove(c);

                }
                else throw new FormatException("No Customers with that Id - NO CUSTORMERS DELETED");
            }


        }
        public Customer SearchForCustomer(int Id)
        {

            foreach (Customer c in customers)

            {
                if (c.Id == Id)
                {
                    return c;
                }

            }
            return null;
        }
        public Customer UpdateCustomer(Customer customer, Adresse adresse, string NewPhonenumber, string NewName)
        {

            foreach (Customer c in customers)
            {
                if (c.Id == customer.Id)

                {
                    c.Adresse = adresse;
                    c.Name = NewName;
                    c.PhoneNumber = NewPhonenumber;
                    return c;

                }

            }
            return null;
        }

        public string PrintMenu()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Customer c in customers) { sb.Append(c); }
            return sb.ToString();
        }

        public Customer AddCustomerToOrder(int id)
        {
            foreach (Customer customer in customers)
            {
                if (id == customer.Id) { return customer; }
                return customer;
            }
            return null;
        }
    }
}
