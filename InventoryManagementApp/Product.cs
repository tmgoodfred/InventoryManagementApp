using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal Price { get; set; }
        public byte[] ProductImage { get; set; }
    }
}
