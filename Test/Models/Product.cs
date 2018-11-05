using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderedProduct = new HashSet<OrderedProduct>();
        }

        public uint Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdate { get; set; }
        public byte CategoryId { get; set; }

        public Category Category { get; set; }
        public ICollection<OrderedProduct> OrderedProduct { get; set; }
    }
}
