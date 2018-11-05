using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class CustomerOrder
    {
        public CustomerOrder()
        {
            OrderedProduct = new HashSet<OrderedProduct>();
        }

        public uint Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
        public uint ConfirmationNumber { get; set; }
        public uint CustomerId { get; set; }

        public Customer Customer { get; set; }
        public ICollection<OrderedProduct> OrderedProduct { get; set; }
    }
}
