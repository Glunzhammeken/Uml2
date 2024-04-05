using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Uml2_Maybe
{
    public class Adresse
    {
        public string city {  get; set; }       
        public string zipcode { get; set; }
        public string streetname { get; set; } 
        public string streetnumber { get; set; }

        public override string ToString()
        {
            return $" City: {city}, Zipcode: {zipcode}, Streetname: {streetname}, Streetnumber: {streetnumber}  \n";
        }
    }
}
