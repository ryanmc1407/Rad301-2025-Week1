using System;
using System.Collections.Generic;

namespace Rad301_2025_Week1
{

    public class ProductModel
    {
        public List<Product> Products { get; set; }
        public List<Supplier> Suppliers { get; set; }
        public List<Category> Categories { get; set; }

        public List<SupplierProduct> SuppliersProducts { get; set; }


        public ProductModel()
        {
            Categories = new List<Category>
            {
                new Category (1, "Hardware"),
                new Category (2, "Electrical Appliances"),
            };

            Products = new List<Product>
            {
                new Product (1, "9 Inch Nails", 200, 0.1f, 1),
                new Product (2, "9 Inch Bolts", 120, 0.2f,1),
                new Product (3, "Chimney Hoover", 10, 100.30f,2),
                new Product (4, "Washing Machine", 7, 399.50f,2),

            };

            Suppliers = new List<Supplier>
            {
               new Supplier (1, "Acme ", "Collooney", "Sligo"),
               new Supplier (2, "Swift Electric", "Finglas", "Dublin"),

            };

            SuppliersProducts = new List<SupplierProduct>
            {
                new SupplierProduct (1, 1, new DateTime(2012,12,12)),
                new SupplierProduct (1, 2, new DateTime(2017,08,13)),
                new SupplierProduct (2, 3, new DateTime(2022,09,09)),
                new SupplierProduct (2, 4, new DateTime(2024,04,11)),
            };

            var LessThan100 = Products.Where(p => p.QuantityInStock <= 100);

            foreach (var product in LessThan100)
            {
                Console.WriteLine(product.QuantityInStock);
            }

            var greaterThan120 = Products.Where(Product => Product.QuantityInStock > 120);

            foreach (var product in greaterThan120)
            {
                Console.WriteLine(product.QuantityInStock);
            }

            var totalValue = Products.Select(p => new { totalValue = p.QuantityInStock * p.UnitPrice }).ToList();

            foreach (var product in totalValue)
            {
                Console.WriteLine(product.totalValue);
            }

            var productsHardwareCategory = from product in Products
                                           join category in Categories on product.ID equals category.ID
                                           select product;

            foreach (var product in productsHardwareCategory)
            {
                Console.WriteLine(product.Description);
            }

            var suppliersAndPart = from suppliersProduct in SuppliersProducts
                                   join product in Products on suppliersProduct.ProductID equals product.ID
                                   join supplier in Suppliers on suppliersProduct.ProductID equals supplier.ID
                                   select new { productName = product.Description, supplierName = supplier.Name };

            foreach (var supplier in suppliersAndPart)
            {
                Console.WriteLine("Last");
                Console.WriteLine(String.Format("Product name is {0} and supplier is {1}", supplier.productName, supplier.supplierName));
            }



        }
    }
}

   

    
    
