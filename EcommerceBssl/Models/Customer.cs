using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace EcommerceBssl.Models
{
    public class Customer: IdentityUser  // the appuser is inheriting for the identity tables
    {
        public List<Address> Addresses { get; set; }
    }
}
