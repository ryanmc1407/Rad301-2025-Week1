using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2025_Week1
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
      
        public int QuantityInStock { get; set; }
        public virtual Category Category { get; set; }

        public ICollection<Supplier> Suppliers { get; set; }

        public Product(int id, string description,  int quantityInStock, float unitPrice, int categoryID)
        {
            ID = id;
              CategoryID = categoryID;
            Description = description;
              UnitPrice = unitPrice;
              
              QuantityInStock = quantityInStock;


        }

    }
}
