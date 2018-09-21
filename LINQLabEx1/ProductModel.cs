﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLabEx1
{
    public class ProductModel
    {
        public List<Product> Products = new List<Product>
        {
            new Product
            {
                ProductID = 1,
                Description = "9'' Nails",
                QuantityInStock = 200,
                UnitPrice = 0.10f,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 2,
                Description = "9'' Bolts",
                QuantityInStock = 120,
                UnitPrice = 0.20f,
                CategoryID = 1
            },
            new Product
            {
                ProductID = 3,
                Description = "Chimney Hoover",
                QuantityInStock = 10,
                UnitPrice = 100.50f,
                CategoryID = 2
            },
            new Product
            {
                ProductID = 4,
                Description = "Washing Machine",
                QuantityInStock = 7,
                UnitPrice = 399.99f,
                CategoryID = 2
            }
        };

        public List<Supplier> Suppliers = new List<Supplier>
        {
            new Supplier
            {
                SupplierID = 1,
                SupplierName = "Parts 1",
                SupplierAddressLine1 = "Addr 11",
                SupplierAddressLine2 = "Addr 21"
            },
            new Supplier
            {
                SupplierID = 2,
                SupplierName = "Parts 2",
                SupplierAddressLine1 = "Addr 11",
                SupplierAddressLine2 = "Addr 21"
            }
        };
        public List<Category> Categories = new List<Category>
        {
            new Category
            {
                id = 1,
                Description = "Hardware"
            },
            new Category
            {
                id = 2,
                Description = "Electrical Appliences"
            }
        };
        public List<SupplierProduct> SupplierProducts = new List<SupplierProduct>
        {
            new SupplierProduct
            {
                SupplierID = 1,
                ProductID = 1,
                DateFirstSupplied = DateTime.Parse("12/12/2012")
            },
            new SupplierProduct
            {
                SupplierID = 1,
                ProductID = 2,
                DateFirstSupplied = DateTime.Parse("06/01/2013")
            },
            new SupplierProduct
            {
                SupplierID = 2,
                ProductID = 3,
                DateFirstSupplied = DateTime.Parse("09/09/2017")
            },
            new SupplierProduct
            {
                SupplierID = 2,
                ProductID = 4,
                DateFirstSupplied = DateTime.Parse("10/09/2017")
            }
        };
    }
}
