using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class OrderedProduct
    {
        public uint CustomerOrderId { get; set; }
        public uint ProductId { get; set; }
        public ushort Quantity { get; set; }

        public CustomerOrder CustomerOrder { get; set; }
        public Product Product { get; set; }
    }
}
