using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIF.Model
{
    public class Account
    {
        public Customer Customer { get; set; }
        public Guid AccountId { get; set; }
    }
}
