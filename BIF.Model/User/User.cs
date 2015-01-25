using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIF.Model
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int CreatedOn { get; set; }

        public BusinessProfile BusinessProfile { get; set; }

        public Organisation Organisation { get; set; }
    }
}
