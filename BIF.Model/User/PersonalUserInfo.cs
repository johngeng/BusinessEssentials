using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BIF.Model
{
    public class PersonalUserInfo : User
    {
        public Guid PersonalUserInfoId { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string Position { get; set; }

        public int CreatedOn { get; set; }

        public string Email { get; set; }
        public int MobilePhone { get; set; }
    }
}
