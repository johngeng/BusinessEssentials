using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIF.Model
{
    public class OrganisationAccess
    {
        public Guid OrganisationAccessId { get; set; }

        public Organisation Organisation { get; set; }

        public PermissionType AppPermissions { get; set; }

        public PermissionType ModulePermissions { get; set; }
    }
}
