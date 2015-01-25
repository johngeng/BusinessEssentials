using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIF.Model
{
    public class Customer
    {
        public Guid CustomerId { get; set; }

        public string Name { get; set; }

        public CustomerType CustomerType { get; set; }

        public bool Active { get; set; }

        public DateTime CreatedOn { get; set; }

        public int Number { get; set; }
    }
}
