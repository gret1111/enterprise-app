using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerOrder = new HashSet<CustomerOrder>();
        }

        public uint Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string CityRegion { get; set; }
        public string CcNumber { get; set; }

        public ICollection<CustomerOrder> CustomerOrder { get; set; }
    }
}
