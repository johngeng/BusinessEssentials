using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIF.Model
{
    public class Organisation
    {
        public int OrganisationId { get; set; }

        public OrganisationType OrganisationType { get; set; }

        public Organisation Parent { get; set; }
        public DateTime CreatedOn { get; set; }

        public bool Active { get; set; }

        public BusinessProfile BusinessProfile { get; set; }
    }
}
