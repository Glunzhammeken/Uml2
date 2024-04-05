using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uml2_Maybe
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price} \n\n";
        }
    }
}





