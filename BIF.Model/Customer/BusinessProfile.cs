using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIF.Model
{
    public class BusinessProfile
    {

        public Customer Customer { get; set; }

        public Guid BusinessProfileId { get; set; }

        public string BusinessName { get; set; }

        public string Description { get; set; }

        public int BusinessActivity { get; set; }

        public int CreatedOn { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

        public int Website { get; set; }
    }
}
