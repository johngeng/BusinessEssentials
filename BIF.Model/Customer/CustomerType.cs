using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIF.Model
{
    public class CustomerType
    {
        public int CustomerTypeId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public int CreatedOn { get; set; }
    }
}
