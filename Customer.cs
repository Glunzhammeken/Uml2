using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml2_Maybe
{
    public class Customer
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public int Id {  get; set; }

        public Adresse Adresse { get; set; }

        public override string ToString()
        {
            return $" Id: {Id}, Name: {Name}, Phonenumber: {PhoneNumber}, \n\n Customers Adresse\n\n {Adresse} \n\n";
        }
        
    }
}
