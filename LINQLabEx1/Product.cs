﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLabEx1
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Description { get; set; }
        public int QuantityInStock { get; set; }
        public float UnitPrice { get; set; }
        public int CategoryID { get; set; }
    }
}
