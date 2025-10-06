using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad301_2025_Week1
{
    public class SupplierProduct
    {
        public int SupplierID { get; set; }
        public int ProductID { get; set; }
        public DateTime DateFirstSupplied { get; set; }

        public virtual Supplier FK_Supplier { get; set; }
        public virtual Product FK_Product { get; set; }

        public SupplierProduct(int supplierID, int productID, DateTime dateFirstSupplied)
        {
            SupplierID = supplierID;
            ProductID = productID;
            DateFirstSupplied = dateFirstSupplied;
        }
    }
}

