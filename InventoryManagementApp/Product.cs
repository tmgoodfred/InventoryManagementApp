﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Blob ProductDescription { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal Price { get; set; }
        public Blob ProductImage { get; set; }
    }
}