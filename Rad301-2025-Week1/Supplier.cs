using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2025_Week1
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        public Supplier(int id, string name, string addressLine1, string addressLine2)
        {
            ID = id;
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;


        }
    }
}