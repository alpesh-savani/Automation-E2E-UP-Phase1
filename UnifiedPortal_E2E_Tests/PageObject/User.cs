using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnifiedPortal_E2E_Tests
{
    public class User
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string DisplayName => $"{GivenName} {LastName}";

        public string GivenName { get; set; }

        public string LastName { get; set; }
    }
}
