using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIF.Model
{
    public class PermissionType
    {
        public int PermissionTypeId { get; set; }

        public bool CanView { get; set; }

        public bool CanEdit { get; set; }

        public bool CanDelete { get; set; }
    }
}
