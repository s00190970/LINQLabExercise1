using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLabEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductModel pModels = new ProductModel();

            // 1.	List all the categories.
            Console.WriteLine("Category list:");
            foreach(var cat in pModels.Categories)
            {
                Console.WriteLine(" - " + cat.Description);
            }
            Console.ReadKey();
            Console.Clear();

            // 2.	List all the Products
            Console.WriteLine("Product list:");
            foreach(var prod in pModels.Products)
            {
                Console.WriteLine(" - " + prod.Description);
            }

            Console.ReadKey();
            Console.Clear();

            // 3.	List Products with a Quantity <= 100 
            Console.WriteLine("Products with a Quantity <= 100:");
            var QuantitySmallerOrEqual100 = pModels.Products.Where(q => q.QuantityInStock <= 100).OrderBy(q => q.QuantityInStock);
            foreach (var item in QuantitySmallerOrEqual100)
            {
                Console.WriteLine(" - {0} has a quantity of {1}", item.Description, item.QuantityInStock); 
            }

            Console.ReadKey();
            Console.Clear();

            // 4.	List all the Products together with their total value
            float totalStockPrice = 0;
            foreach (var prod in pModels.Products)
            {
                Console.WriteLine("Product {0} costs {1} euros, has {2} pieces in stock and has a total value of {3} euros", 
                    prod.Description, prod.UnitPrice, prod.QuantityInStock, prod.UnitPrice*prod.QuantityInStock);
                totalStockPrice += prod.UnitPrice * prod.QuantityInStock;
            }
            Console.WriteLine("Total stock value is {0} euros", totalStockPrice);

            Console.ReadKey();
            Console.Clear();

            // 5.	List all the Products in the Hardware Category
            Console.WriteLine("Products in Hardware Category:");
            var hardwareProducts = (from category in pModels.Categories
                                    join product in pModels.Products
                                    on category.id equals product.CategoryID
                                    where category.id == 1
                                    select new { productName = product.Description });
            foreach (var prod in hardwareProducts)
            {
                Console.WriteLine(" - " + prod.productName);
            }

            Console.ReadKey();
            Console.Clear();

            // 6.	List all the suppliers and their Parts ordered by supplier name
            Console.WriteLine("Suppliers and their Parts:");
            var supplierAndParts = (from supplier in pModels.Suppliers
                                    join supProd in pModels.SupplierProducts
                                    on supplier.SupplierID equals supProd.SupplierID
                                    join product in pModels.Products
                                    on supProd.ProductID equals product.ProductID
                                    select new { supplierName = supplier.SupplierName, productName = product.Description })
                                    .OrderBy(o => o.supplierName);
            foreach (var item in supplierAndParts)
            {
                Console.WriteLine(" - " + item.supplierName + " : " + item.productName);
            }

            Console.ReadKey();
        }
    }
}
